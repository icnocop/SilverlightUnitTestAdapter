// <copyright file="DiscoveryInfo.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <summary>
    /// The discovery information.
    /// </summary>
    [Serializable]
    public class DiscoveryInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveryInfo"/> class.
        /// </summary>
        public DiscoveryInfo()
        {
            this.Tags = new Collection<string>();
        }

        /// <summary>
        /// Gets or sets the assembly qualified name.
        /// </summary>
        /// <value>The assembly qualified name.</value>
        public string AssemblyQualifiedName { get; set; }

        /// <summary>
        /// Gets or sets the name of the assembly.
        /// </summary>
        /// <value>The name of the assembly.</value>
        public string AssemblyName { get; set; }

        /// <summary>
        /// Gets or sets the assembly path.
        /// </summary>
        /// <value>The assembly path.</value>
        public string AssemblyPath { get; set; }

        /// <summary>
        /// Gets or sets the class file path.
        /// </summary>
        /// <value>The class file path.</value>
        public string ClassFilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the class.
        /// </summary>
        /// <value>The name of the class.</value>
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets the line of code.
        /// </summary>
        /// <value>The line of code.</value>
        public int LineOfCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the method.
        /// </summary>
        /// <value>The name of the method.</value>
        public string MethodName { get; set; }

        /// <summary>
        /// Gets or sets the namespace.
        /// </summary>
        /// <value>The namespace.</value>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets the tags.
        /// </summary>
        /// <value>The tags.</value>
        public Collection<string> Tags { get; }

        /// <summary>
        /// Gets the full method path.
        /// </summary>
        /// <returns>System.String.</returns>
        public string GetFullMethodPath()
        {
            string[] @namespace = { this.Namespace, this.ClassName, this.MethodName };
            IEnumerable<string> parts =
                from x in @namespace
                where !string.IsNullOrEmpty(x)
                select x;
            return string.Join(".", parts);
        }
    }
}