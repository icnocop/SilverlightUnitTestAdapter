// <copyright file="SerializationHelperTest.cs" company="Niels Hebling, Rami Abughazaleh, and contributors">
//   Copyright (c) Niels Hebling, Rami Abughazaleh, and contributors.  All rights reserved.
// </copyright>

namespace SilverlightUnitTestAdapterTest
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json;
    using SilverlightUnitTestAdapter.Configuration;
    using StatLight.Core.Configuration;

    /// <summary>
    /// Serialization Helper Test.
    /// </summary>
    [TestClass]
    public class SerializationHelperTest
    {
        /// <summary>
        /// Converts the settings containing a query string to JSON.
        /// </summary>
        [TestMethod]
        public void ToJson_WithQueryString_Succeeds()
        {
            Settings settings = new Settings
            {
                QueryString = new Dictionary<string, string>
                {
                    { "test", "value" }
                }
            };

            string json = JsonConvert.SerializeObject(settings);

            Assert.AreEqual("{\"QueryString\":{\"test\":\"value\"}}", json);
        }

        /// <summary>
        /// Converts the JSON string containing a query string to an instance of settings.
        /// </summary>
        [TestMethod]
        public void FromJson_WithQueryString_Succeeds()
        {
            string json = "{\"QueryString\":{\"test\":\"value\"}}";
            Settings settings = JsonConvert.DeserializeObject<Settings>(json);

            Assert.AreEqual(1, settings.QueryString.Count);
            Assert.AreEqual("value", settings.QueryString["test"]);
            Assert.IsNull(settings.Plugins);
        }

        /// <summary>
        /// Converts the settings containing a unit test provider to JSON.
        /// </summary>
        [TestMethod]
        public void ToJson_WithUnitTestProvider_Succeeds()
        {
            Settings settings = new Settings
            {
                UnitTestProvider = UnitTestProviderType.MSTestWithCustomProvider
            };

            string json = JsonConvert.SerializeObject(settings);

            Assert.AreEqual("{\"UnitTestProvider\":\"MSTestWithCustomProvider\"}", json);
        }

        /// <summary>
        /// Converts the JSON string containing a unit test provider to an instance of settings.
        /// </summary>
        [TestMethod]
        public void FromJson_WithUnitTestProvider_Succeeds()
        {
            string json = "{\"UnitTestProvider\": \"MSTestWithCustomProvider\"}";
            Settings settings = JsonConvert.DeserializeObject<Settings>(json);

            Assert.AreEqual(UnitTestProviderType.MSTestWithCustomProvider, settings.UnitTestProvider);
        }

        /// <summary>
        /// Asserts that converting a JSON string of settings without a unit test provider is converted with an undefined unit test provider.
        /// </summary>
        [TestMethod]
        public void FromJson_WithoutUnitTestProvider_IsUndefinedByDefault()
        {
            string json = "{}";
            Settings settings = JsonConvert.DeserializeObject<Settings>(json);

            Assert.AreEqual(UnitTestProviderType.Undefined, settings.UnitTestProvider);
        }

        /// <summary>
        /// Asserts that converting a JSON string of settings with the Debug property set to true is converted with the Debug property set to true.
        /// </summary>
        [TestMethod]
        public void FromJson_WithDebug_DebugIsSet()
        {
            string json = "{ \"Debug\" : true }";
            Settings settings = JsonConvert.DeserializeObject<Settings>(json);

            Assert.AreEqual(true, settings.Debug);
        }
    }
}
