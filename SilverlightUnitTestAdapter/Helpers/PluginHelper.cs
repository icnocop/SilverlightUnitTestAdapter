// <copyright file="PluginHelper.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
    using SilverlightUnitTestAdapter.Configuration;
    using SilverlightUnitTestAdapter.Plugin;

    /// <summary>
    /// Plugin Helper.
    /// </summary>
    public class PluginHelper
    {
        private readonly IMessageLogger logger;
        private readonly string testAssemblyFilePath;
        private readonly TestResult testResult;
        private string currentPluginPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginHelper" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="testAssemblyFilePath">The test assembly file path.</param>
        /// <param name="testResult">The test result.</param>
        internal PluginHelper(IMessageLogger logger, string testAssemblyFilePath, TestResult testResult)
        {
            this.logger = logger;
            this.testAssemblyFilePath = testAssemblyFilePath;
            this.testResult = testResult;
        }

        /// <summary>
        /// Transforms the test results.
        /// </summary>
        internal void TransformTestResults()
        {
            IEnumerable<Tuple<object, string>> plugins = this.LoadPlugins();

            foreach (Tuple<object, string> plugin in plugins)
            {
                this.TransformTestResults(plugin);
            }
        }

        private void TransformTestResults(Tuple<object, string> plugin)
        {
            object pluginInstance = plugin.Item1;
            string pluginFilePath = plugin.Item2;

            this.logger.SendMessage(TestMessageLevel.Informational, "Calling TransformTestResult...");

            this.currentPluginPath = Path.GetDirectoryName(pluginFilePath);

            AppDomain.CurrentDomain.AssemblyResolve += this.OnAssemblyResolve;

            try
            {
                Type type = pluginInstance.GetType();
                MethodInfo methodInfo = type.GetMethod(nameof(IPlugin.TransformTestResult), BindingFlags.Instance | BindingFlags.Public);
                if (methodInfo == null)
                {
                    this.logger.SendMessage(TestMessageLevel.Error, $"Failed to get method '{nameof(IPlugin.TransformTestResult)}' from instance of type '{type}'.");
                    return;
                }

                ParameterInfo[] parameterInfos = methodInfo.GetParameters();
                foreach (ParameterInfo parameterInfo in parameterInfos)
                {
                    this.logger.SendMessage(TestMessageLevel.Informational, $"Found method with parameter '{parameterInfo.Name}' of type '{parameterInfo.ParameterType.FullName}'.");
                }

                this.logger.SendMessage(TestMessageLevel.Informational, $"Calling method with parameters '{this.logger.GetType().FullName}' and '{this.testResult.GetType().FullName}'.");

                object[] parameters = { this.logger, this.testResult };

                methodInfo.Invoke(pluginInstance, parameters);
            }
            catch (Exception ex)
            {
                this.logger.SendMessage(TestMessageLevel.Error, $"TranformTestResult threw an exception: {ex}");
            }
            finally
            {
                AppDomain.CurrentDomain.AssemblyResolve -= this.OnAssemblyResolve;
            }
        }

        private string GetTestAssemblyDirectory()
        {
            string assemblyPath = Path.GetDirectoryName(this.testAssemblyFilePath);
            if (assemblyPath == null)
            {
                throw new Exception($"Failed to get directory name for assembly location: {this.testAssemblyFilePath}");
            }

            return assemblyPath;
        }

        private IEnumerable<string> GetPluginFilePaths()
        {
            List<string> pluginFilePaths = new List<string>();
            string assemblyPath = this.GetTestAssemblyDirectory();

            string configurationFilePath = Path.Combine(assemblyPath, SilverlightUnitTestAdapter.Constants.ConfigurationFileName);
            if (!File.Exists(configurationFilePath))
            {
                this.logger.SendMessage(TestMessageLevel.Informational, $"Configuration file '{configurationFilePath}' not found.");
                return pluginFilePaths;
            }

            Settings settings = Settings.Load(configurationFilePath);

            if (settings.Plugins == null)
            {
                this.logger.SendMessage(TestMessageLevel.Informational, $"No plugins defined in configuration file {configurationFilePath}.");
                return pluginFilePaths;
            }

            foreach (string pluginFilePath in settings.Plugins)
            {
                string normalizedPluginFilePath = pluginFilePath;

                if (!Path.IsPathRooted(pluginFilePath))
                {
                    normalizedPluginFilePath = Path.Combine(assemblyPath, pluginFilePath);
                }

                string fullPath = Path.GetFullPath(normalizedPluginFilePath);
                pluginFilePaths.Add(fullPath);
            }

            return pluginFilePaths;
        }

        private IEnumerable<Tuple<object, string>> LoadPlugins()
        {
            IEnumerable<string> pluginFilePaths = this.GetPluginFilePaths();
            List<Tuple<object, string>> plugins = new List<Tuple<object, string>>();

            foreach (string pluginFilePath in pluginFilePaths)
            {
                plugins.AddRange(this.LoadPlugin(pluginFilePath));
            }

            return plugins;
        }

        private IEnumerable<Tuple<object, string>> LoadPlugin(string pluginFilePath)
        {
            List<Tuple<object, string>> plugins = new List<Tuple<object, string>>();

            if (!File.Exists(pluginFilePath))
            {
                this.logger.SendMessage(TestMessageLevel.Error, $"Plugin doesn't exist: {pluginFilePath}");
                return plugins;
            }

            this.logger.SendMessage(TestMessageLevel.Informational, $"Loading plugin: {pluginFilePath}");

            this.currentPluginPath = Path.GetDirectoryName(pluginFilePath);

            AppDomain.CurrentDomain.AssemblyResolve += this.OnAssemblyResolve;

            try
            {
                Assembly pluginAssembly = Assembly.LoadFile(pluginFilePath);
                Type[] types = pluginAssembly.GetExportedTypes();
                foreach (var type in types)
                {
                    if (!type.IsClass || type.GetInterface(typeof(IPlugin).FullName) == null)
                    {
                        continue;
                    }

                    var pluginInstance = Activator.CreateInstance(type);

                    this.logger.SendMessage(TestMessageLevel.Informational, $"Loaded plugin type: '{type.FullName}'");

                    plugins.Add(new Tuple<object, string>(pluginInstance, pluginFilePath));
                }
            }
            finally
            {
                AppDomain.CurrentDomain.AssemblyResolve -= this.OnAssemblyResolve;
            }

            return plugins;
        }

        private Assembly OnAssemblyResolve(object sender, ResolveEventArgs args)
        {
            AssemblyName assemblyName = new AssemblyName(args.Name);
            string fileName = $"{assemblyName.Name}.dll";

            string filePath = Path.Combine(this.currentPluginPath, fileName);
            if (File.Exists(filePath))
            {
                this.logger.SendMessage(TestMessageLevel.Informational, $"Loading assembly '{filePath}'.");

                return Assembly.LoadFile(filePath);
            }

            this.logger.SendMessage(TestMessageLevel.Error, $"Could not find '{args.Name}' in '{this.currentPluginPath}'.");

            return null;
        }
    }
}
