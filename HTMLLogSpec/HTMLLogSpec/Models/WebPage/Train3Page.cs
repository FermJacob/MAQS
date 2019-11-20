using System;
using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Magenic.Maqs.Utilities.Helper;
using OpenQA.Selenium;

namespace Models
{
    /// <summary>
    /// Page object for the HomePageModel page
    /// </summary>
    public class Train3Page : BaseSeleniumPageModel
    {
        /// <summary>
        /// The page url
        /// </summary>
        public readonly string Train3PageUrl = SeleniumConfig.GetWebSiteBase() + "Static/Training3/HomePage.html";

        /// <summary>
        /// Initializes a new instance of the <see cref="Train3Page" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public Train3Page(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        /// Gets welcome message
        /// </summary>
        private LazyElement WelcomeMessage
        {
            get { return this.GetLazyElement(By.CssSelector("#WelcomeMessage"), "Welcome message"); }
        }

        /// <summary>
        /// Check if the home page has been loaded
        /// </summary>
        /// <returns>True if the page was loaded</returns>
        public override bool IsPageLoaded()
        {
            return this.WelcomeMessage.Displayed;
        }

        /// <summary>
        /// Open the login page
        /// </summary>
        public HomePage GotoBase()
        {
            this.TestObject.WebDriver.Navigate().GoToUrl(SeleniumConfig.GetWebSiteBase());
            return new HomePage(this.TestObject);
        }
    }
}

