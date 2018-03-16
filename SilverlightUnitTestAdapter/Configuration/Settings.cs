// <copyright file="Settings.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapter.Configuration
{
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using global::StatLight.Core.Configuration;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Settings.
    /// </summary>
    [DataContract]
    public class Settings
    {
        /// <summary>
        /// Gets or sets the query string.
        /// </summary>
        /// <value>The query string.</value>
        [DataMember(EmitDefaultValue = false)]
        public Dictionary<string, string> QueryString { get; set; }

        /// <summary>
        /// Gets or sets the plugins.
        /// </summary>
        /// <value>The plugins.</value>
        [DataMember(EmitDefaultValue = false)]
        public ICollection<string> Plugins { get; set; }

        /// <summary>
        /// Gets or sets the unit test provider.
        /// </summary>
        /// <value>The unit test provider.</value>
        [DataMember(EmitDefaultValue = false)]
        [JsonConverter(typeof(StringEnumConverter))]
        public UnitTestProviderType UnitTestProvider { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to turn on debug tracing.
        /// </summary>
        /// <value><c>true</c> if debug tracing is turned on; otherwise, <c>false</c>.</value>
        [DataMember(EmitDefaultValue = false)]
        public bool Debug { get; set; }

        /// <summary>
        /// Gets or sets the overridden settings.
        /// </summary>
        /// <value>The overridden settings.</value>
        [DataMember(EmitDefaultValue = false)]
        public Dictionary<string, string> OverriddenSettings { get; set; }

        /// <summary>
        /// Loads the settings from the specified configuration file path.
        /// </summary>
        /// <param name="configurationFilePath">The configuration file path.</param>
        /// <returns>Settings.</returns>
        /// <value>
        /// The settings.
        /// </value>
        public static Settings Load(string configurationFilePath)
        {
            string jsonConfiguration = File.ReadAllText(configurationFilePath);
            return JsonConvert.DeserializeObject<Settings>(jsonConfiguration);
        }
    }
}
