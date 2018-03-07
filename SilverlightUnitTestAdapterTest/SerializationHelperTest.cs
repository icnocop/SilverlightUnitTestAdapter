// <copyright file="SerializationHelperTest.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapterTest
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SilverlightUnitTestAdapter.Configuration;
    using SilverlightUnitTestAdapter.Helpers;

    /// <summary>
    /// Serialization Helper Test.
    /// </summary>
    [TestClass]
    public class SerializationHelperTest
    {
        /// <summary>
        /// Converts the settings to json.
        /// </summary>
        [TestMethod]
        public void ToJson_WithQueryString_Succeeds()
        {
            string json = SerializationHelper.ToJson(new Settings
            {
                QueryString = new Dictionary<string, string>
                {
                    { "test", "value" }
                }
            });

            Assert.AreEqual("{\"QueryString\":{\"test\":\"value\"}}", json);
        }

        /// <summary>
        /// Converts the json to settings.
        /// </summary>
        [TestMethod]
        public void FromJson_WithQueryString_Succeeds()
        {
            string json = "{\"QueryString\":{\"test\":\"value\"}}";
            Settings settings = SerializationHelper.FromJson<Settings>(json);

            Assert.AreEqual(1, settings.QueryString.Count);
            Assert.IsTrue(settings.QueryString.ContainsKey("test"));
            Assert.AreEqual("value", settings.QueryString["test"]);
            Assert.IsNull(settings.Plugins);
        }
    }
}
