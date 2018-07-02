﻿using Magenic.MaqsFramework.BaseWebServiceTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebServiceModel;

namespace $safeprojectname$
{
    /// <summary>
    /// $safeprojectname$ test class
    /// </summary>
    [TestClass]
    public class WebServiceTest : BaseWebServiceTest
    {
        /// <summary>
        /// Get single product as XML
        /// </summary>
        [TestMethod]
        public void GetXmlDeserialized()
        {
            ProductXml result = this.WebServiceWrapper.Get<ProductXml>("/api/XML_JSON/GetProduct/1", "application/xml", false);

            Assert.AreEqual(result.Id, 1, "Expected to get product 1");
        }

        /// <summary>
        /// Get single product as Json
        /// </summary>
        [TestMethod]
        public void GetJsonDeserialized()
        {
            ProductJson result = this.WebServiceWrapper.Get<ProductJson>("/api/XML_JSON/GetProduct/1", "application/json", false);

            Assert.AreEqual(result.Id, 1, "Expected to get product 1");
        }
    }
}