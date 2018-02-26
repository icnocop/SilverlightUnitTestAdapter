// <copyright file="Settings.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace Configuration
{
    using System.IO;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "configuration")]
    public class Settings
    {
        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public static Settings Load(string configurationFilePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));
            
            FileStream fileStream = new FileStream(configurationFilePath, FileMode.Open);

            return (Settings)xmlSerializer.Deserialize(fileStream);
        }
        
        [XmlArray("queryString")]
        [XmlArrayItem("add", typeof(NameValuePair))]
        public NameValuePair[] QueryString { get; set; }
    }
}
