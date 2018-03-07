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
    using SilverlightUnitTestAdapter.Configuration;
    using SilverlightUnitTestAdapter.Plugin;

    /// <summary>
    /// Plugin Helper.
    /// </summary>
    public class PluginHelper
    {
        private readonly IVsShell shell;
        private readonly string testAssemblyFilePath;
        private readonly TestResult testResult;
        private string currentPluginPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginHelper"/> class.
        /// </summary>
        /// <param name="shell">The shell.</param>
        /// <param name="testAssemblyFilePath">The test assembly file path.</param>
        /// <param name="testResult">The test result.</param>
        internal PluginHelper(IVsShell shell, string testAssemblyFilePath, TestResult testResult)
        {
            this.shell = shell;
            this.testAssemblyFilePath = testAssemblyFilePath;
            this.testResult = testResult;
        }

        /// <summary>
        /// Transforms the test results.
        /// </summary>
        internal void TransformTestResults()
        {
            List<Tuple<object, string>> plugins = this.LoadPlugins();

            ILogger logger = new Logger(this.shell);

            foreach (Tuple<object, string> plugin in plugins)
            {
                this.TransformTestResults(plugin, logger, this.testResult);
            }
        }

        private void TransformTestResults(Tuple<object, string> plugin, ILogger logger, TestResult testResult)
        {
            object pluginInstance = plugin.Item1;
            string pluginFilePath = plugin.Item2;

            this.shell.Trace("Calling TransformTestResult...");

            this.currentPluginPath = Path.GetDirectoryName(pluginFilePath);

            AppDomain.CurrentDomain.AssemblyResolve += this.OnAssemblyResolve;

            try
            {
                Type type = pluginInstance.GetType();
                MethodInfo methodInfo = type.GetMethod(nameof(IPlugin.TransformTestResult), BindingFlags.Instance | BindingFlags.Public);
                if (methodInfo == null)
                {
                    this.shell.Trace($"Failed to get method '{nameof(IPlugin.TransformTestResult)}' from instance of type '{type}'.");
                    return;
                }

                ParameterInfo[] parameterInfos = methodInfo.GetParameters();
                foreach (ParameterInfo parameterInfo in parameterInfos)
                {
                    this.shell.Trace($"Found method with parameter '{parameterInfo.Name}' of type '{parameterInfo.ParameterType.FullName}'.");
                }

                this.shell.Trace($"Calling method with parameters '{logger.GetType().FullName}' and '{this.testResult.GetType().FullName}'.");

                object[] parameters = new object[] { logger, this.testResult };

                methodInfo.Invoke(pluginInstance, parameters);
            }
            catch (Exception ex)
            {
                this.shell.Trace($"TranformTestResult threw an exception: {ex}");
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

        private List<string> GetPluginFilePaths()
        {
            List<string> pluginFilePaths = new List<string>();
            string assemblyPath = this.GetTestAssemblyDirectory();

            string configurationFilePath = Path.Combine(assemblyPath, SilverlightUnitTestAdapter.Constants.ConfigurationFileName);
            if (!File.Exists(configurationFilePath))
            {
                this.shell.Trace($"Configuration file '{configurationFilePath}' not found.");
                return pluginFilePaths;
            }

            Settings settings = Settings.Load(configurationFilePath);

            if (settings.Plugins == null)
            {
                this.shell.Trace($"No plugins defined in configuration file {configurationFilePath}.");
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

        private List<Tuple<object, string>> LoadPlugins()
        {
            List<string> pluginFilePaths = this.GetPluginFilePaths();
            List<Tuple<object, string>> plugins = new List<Tuple<object, string>>();

            foreach (string pluginFilePath in pluginFilePaths)
            {
                plugins.AddRange(this.LoadPlugin(pluginFilePath));
            }

            return plugins;
        }

        private List<Tuple<object, string>> LoadPlugin(string pluginFilePath)
        {
            List<Tuple<object, string>> plugins = new List<Tuple<object, string>>();

            if (!File.Exists(pluginFilePath))
            {
                this.shell.Trace($"Plugin doesn't exist: {pluginFilePath}");
                return plugins;
            }

            this.shell.Trace($"Loading plugin: {pluginFilePath}");

            this.currentPluginPath = Path.GetDirectoryName(pluginFilePath);

            AppDomain.CurrentDomain.AssemblyResolve += this.OnAssemblyResolve;

            try
            {
                Assembly pluginAssembly = Assembly.LoadFile(pluginFilePath);
                Type[] types = pluginAssembly.GetExportedTypes();
                foreach (var type in types)
                {
                    if (type.IsClass && (type.GetInterface(typeof(IPlugin).FullName) != null))
                    {
                        var pluginInstance = Activator.CreateInstance(type);

                        this.shell.Trace($"Loaded plugin type: '{type.FullName}'");

                        plugins.Add(new Tuple<object, string>(pluginInstance, pluginFilePath));
                    }
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
                this.shell.Trace(string.Concat($"Loading assembly '{filePath}'."));

                return Assembly.LoadFile(filePath);
            }
            else
            {
                this.shell.Trace($"Could not find '{args.Name}' in '{this.currentPluginPath}'.");
            }

            return null;
        }
    }
}
