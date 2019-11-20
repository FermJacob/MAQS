using Magenic.Maqs.BaseDatabaseTest;
using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseWebServiceTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.Data;
using System.Linq;

namespace Tests
{
    /// <summary>
    /// Composite Selenium test class
    /// </summary>
    [TestClass]
    public class SeleniumTest : BaseSeleniumTest
    {



        /// <summary>
        /// A stepwise test into the automation elements page
        /// </summary>
        [TestMethod]
        public void StepwiseTest()
        {
            string username = "Ted";
            string password = "123";
            LoginPageModel loginpage = new LoginPageModel(this.TestObject);

            this.LogIntent("Navigate to App Login Url: " + loginpage.LoginPageUrl);
            loginpage.OpenLoginPage();

            this.LogIntent("Login with user: " + username);
            Train3Page train3 = loginpage.LoginWithValidCredentials(username, password);

            this.LogIntent("Go to the Home Page");
            HomePage home = train3.GotoBase();

            this.LogIntent("Open the Automation Elements Page");
            AutoElementsPage aepage = home.SelectAutomationElementsPage();

            this.LogIntent("Click the first \"show Dialog\" button");
            aepage.OpenDialog1();

            bool open = aepage.Dialog1IsDisplayed();
            this.SoftAssert.IsTrue(open, "Assert that the dialog is open");
            if (open)
            {
                //Finish the test
                this.LogIntent("Assert:Check the dialog message");
                string thetext = aepage.GetDialog1Text();
                this.SoftAssert.AreEqual("Please Wait....", thetext, "Check that dialog Text Matched");

                this.LogIntent("Close the dialog");
                aepage.CloseDialog1();

                this.LogIntent("Assert:dialog closed");
                open = aepage.Dialog1IsDisplayed();
                this.SoftAssert.IsFalse(open, "Verify Dialog1 is closed", "Dialog 1 (Loading) is till open!!!");
            } 
            else
            {
                // Dialog did not open, alternate path
                this.Log.LogMessage(Magenic.Maqs.Utilities.Logging.MessageType.ERROR, "There are Missing Asserts, as the expected dialog never appeared.");
            }      
        }
        /// <summary>
        /// Log the intent of the step.  I do NOT anticipate having to implement this.
        /// It is an illustration mechanism.
        /// </summary>
        public void LogIntent(string msg)
        {
            this.Log.LogMessage(Magenic.Maqs.Utilities.Logging.MessageType.INFORMATION, "INTENT: " + msg);
        }
    }
}
