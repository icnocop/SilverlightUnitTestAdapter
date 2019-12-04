// <copyright file="VsExtensions.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.Shell.Interop;

    /// <summary>
    /// Extensions for getting Visual Studio projects, and their items; since the API for this is crufty.
    /// </summary>
    internal static class VsExtensions
    {
        /// <summary>
        /// Gets the projects.
        /// </summary>
        /// <param name="solutionService">The solution service.</param>
        /// <returns>The projects.</returns>
        public static IEnumerable<IVsHierarchy> GetProjects(this IVsSolution solutionService)
        {
            IEnumHierarchies projects;
            var result = solutionService.GetProjectEnum((uint)__VSENUMPROJFLAGS.EPF_ALLINSOLUTION, Guid.Empty, out projects);

            if (result == VSConstants.S_OK)
            {
                IVsHierarchy[] hierarchy = new IVsHierarchy[1] { null };
                uint fetched = 0;
                for (projects.Reset(); projects.Next(1, hierarchy, out fetched) == VSConstants.S_OK && fetched == 1; /*nothing*/)
                {
                    yield return hierarchy[0];
                }
            }
        }

        /// <summary>
        /// Gets the project output file path.
        /// </summary>
        /// <param name="hierarchy">The hierarchy.</param>
        /// <returns>The project output file paths.</returns>
        public static string GetProjectOutputFilePath(this IVsHierarchy hierarchy)
        {
            // VSITEMID_ROOT gets the current project.
            var itemid = VSConstants.VSITEMID_ROOT;

            object objProj;
            hierarchy.GetProperty(itemid, (int)__VSHPROPID.VSHPROPID_ExtObject, out objProj);

            var project = objProj as EnvDTE.Project;
            if (project == null)
            {
                return null;
            }

            object[] extenderNames = (object[])project.ExtenderNames;
            if (extenderNames == null)
            {
                return null;
            }

            if (extenderNames.Length == 0)
            {
                return null;
            }

            if (!extenderNames.Any(x => x.ToString() == "SilverlightProject"))
            {
                return null;
            }

            if (project.Properties == null)
            {
                return null;
            }

            string projectFilePath = project.FullName;
            if (string.IsNullOrEmpty(projectFilePath))
            {
                return null;
            }

            string projectPath = Path.GetDirectoryName(project.FullName);

            if (project.ConfigurationManager == null)
            {
                return null;
            }

            string outputPath = null;

            try
            {
                outputPath = project.ConfigurationManager.ActiveConfiguration.Properties.Item("OutputPath").Value.ToString();
            }
            catch (ArgumentException)
            {
                // The parameter is incorrect. (Exception from HRESULT: 0x80070057(E_INVALIDARG))
                return null;
            }

            if (string.IsNullOrEmpty(outputPath))
            {
                return null;
            }

            string outputDir = Path.Combine(projectPath, outputPath);

            if (project.Properties == null)
            {
                return null;
            }

            string outputFileName = project.Properties.Item("OutputFileName")?.Value.ToString();
            if (string.IsNullOrEmpty(outputFileName))
            {
                return null;
            }

            return Path.Combine(outputDir, outputFileName);
        }
    }
}
