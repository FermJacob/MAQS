using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using Magenic.Maqs.Utilities.Helper;
using OpenQA.Selenium;

namespace Models
{
    /// <summary>
    /// Page object for the HomePageModel page
    /// </summary>
    public class HomePage : BaseSeleniumPageModel
    {
        /// <summary>
        /// The page url
        /// </summary>
        public static readonly string PageUrl = SeleniumConfig.GetWebSiteBase();

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage" /> class.
        /// </summary>
        /// <param name="testObject">The selenium test object</param>
        public HomePage(SeleniumTestObject testObject) : base(testObject)
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
        /// Gets LazyElement for Employee menu Button
        /// </summary>
        private LazyElement AutomationButton
        {
            get { return this.GetLazyElement(By.CssSelector("#AutomationButton"), "Automation Page Elements Menu Item"); }
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
        /// Navigate to Base Page
        /// </summary>
        public HomePage GotoBase()
        {
            this.TestObject.WebDriver.Navigate().GoToUrl(PageUrl);
            return new HomePage(this.TestObject);
        }

        /// <summary>
        /// Navigate to Employee list
        /// </summary>
        public AutoElementsPage SelectAutomationElementsPage()
        {
            // Click on the AutomationMenu
            var elementlist = this.WebDriver.FindElements(By.CssSelector("*[data-toggle='dropdown']"));
            foreach (IWebElement we in elementlist)
            {
                if (we.Text.Equals("Automation"))
                {
                    we.Click();
                    break;
                }
            }
            this.AutomationButton.Click();
            return new AutoElementsPage(this.TestObject);
        }

    }
}

