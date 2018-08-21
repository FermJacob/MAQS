﻿//--------------------------------------------------
// <copyright file="SeleniumDriverManagerTests.cs" company="Magenic">
//  Copyright 2018 Magenic, All rights Reserved
// </copyright>
// <summary>Selenium driver store tests</summary>
//--------------------------------------------------
using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Magenic.Maqs.WebServiceTester;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Net.Http;

namespace CompositeUnitTests
{
    /// <summary>
    /// Test the Selenium driver store
    /// </summary>
    [TestClass]
    public class SeleniumDriverManagerTests : BaseSeleniumTest
    {
        /// <summary>
        /// Make sure we can override the driver
        /// </summary>
        [TestMethod]
        public void CanOverrideWebDriver()
        {
            IWebDriver tempDriver = SeleniumConfig.Browser("phantomjs");
            this.WebDriver = tempDriver;

            Assert.AreEqual(this.TestObject.WebDriver.GetLowLevelDriver(), tempDriver.GetLowLevelDriver());
        }

        /// <summary>
        /// Check that we can add multiples of the same driver type, provided we use a key
        /// </summary>
        [TestMethod]
        public void CanUseMultiple()
        {
            SeleniumDriverManager newDriver = new SeleniumDriverManager(() => SeleniumConfig.Browser("phantomjs"), this.TestObject);
            this.ManagerStore.Add("test", newDriver);

            Assert.AreNotEqual(this.TestObject.WebDriver.GetLowLevelDriver(), ((SeleniumDriverManager)this.ManagerStore["test"]).GetWebDriver().GetLowLevelDriver());
        }

        /// <summary>
        /// Make sure the test object driver is the same as the one in the driver store
        /// </summary>
        [TestMethod]
        public void SeleniumWebDriverInDriverStore()
        {
            Assert.AreEqual(this.TestObject.WebDriver, this.TestObject.GetDriverManager<SeleniumDriverManager>().Get());
        }

        /// <summary>
        /// Make sure we can add different driver types
        /// </summary>
        [TestMethod]
        public void MixedStoreTypes()
        {
            this.TestObject.AddDriverManager(new WebServiceDriverManager(() => new HttpClient(), this.TestObject));

            Assert.IsNotNull(this.TestObject.GetDriverManager<SeleniumDriverManager>(), "Expected a Selenium driver store");
            Assert.IsNotNull(this.TestObject.GetDriverManager<WebServiceDriverManager>(), "Expected a web service driver store");
        }

        /// <summary>
        /// Make sure separate interactions go to separate drivers
        /// </summary>
        [TestMethod]
        public void SeparateInteractions()
        {
            SeleniumDriverManager newDriver = new SeleniumDriverManager(() => SeleniumConfig.Browser("phantomjs"), this.TestObject);
            newDriver.GetWebDriver().Navigate().GoToUrl("http://magenicautomation.azurewebsites.net/");

            this.ManagerStore.Add("test", newDriver);

            this.TestObject.WebDriver.Navigate().GoToUrl("http://magenicautomation.azurewebsites.net/Automation");

            Assert.AreNotEqual(this.TestObject.WebDriver.Url, ((SeleniumDriverManager)this.ManagerStore["test"]).GetWebDriver().Url);
        }

        /// <summary>
        /// Make sure the driver is  initialized if we use it
        /// </summary>
        [TestMethod]
        public void Intialized()
        {
            // Do something so we intialize the web driver
            this.WebDriver.Manage().Window.Maximize();

            SeleniumDriverManager driverDriver = this.ManagerStore[typeof(SeleniumDriverManager).FullName] as SeleniumDriverManager;
            Assert.IsTrue(driverDriver.IsDriverIntialized(), "The driver should have been intialized");
        }

        /// <summary>
        /// Make sure the driver is not initialized if we don't use it
        /// </summary>
        [TestMethod]
        public void NotIntialized()
        {
            SeleniumDriverManager driverDriver = this.ManagerStore[typeof(SeleniumDriverManager).FullName] as SeleniumDriverManager;
            Assert.IsFalse(driverDriver.IsDriverIntialized(), "The driver should not be intialized until it gets used");
        }
    }
}