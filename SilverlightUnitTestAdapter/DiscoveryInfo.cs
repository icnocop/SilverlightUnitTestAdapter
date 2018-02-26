// <copyright file="DiscoveryInfo.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [Serializable]
    public class DiscoveryInfo
    {
        public string AssemblyFQDN
        {
            get;
            set;
        }

        public string AssemblyName
        {
            get;
            set;
        }

        public string AssemblyPath
        {
            get;
            set;
        }

        public string ClassFilePath
        {
            get;
            set;
        }

        public string ClassName
        {
            get;
            set;
        }

        public int LineOfCode
        {
            get;
            set;
        }

        public string MethodName
        {
            get;
            set;
        }

        public string Namespace
        {
            get;
            set;
        }

        public List<string> Tags
        {
            get;
            set;
        }

        public DiscoveryInfo()
        {
            this.Tags = new List<string>();
        }

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