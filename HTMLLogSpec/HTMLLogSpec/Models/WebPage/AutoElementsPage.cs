using Magenic.Maqs.BaseSeleniumTest;
using Magenic.Maqs.BaseSeleniumTest.Extensions;
using OpenQA.Selenium;

namespace Models
{
    public class AutoElementsPage : HomePage
    {
        public AutoElementsPage(SeleniumTestObject testObject) : base(testObject)
        {
        }

        /// <summary>
        ///  LazyElement for showDialog Button
        /// </summary>
        private LazyElement ShowDialog1Button
        {
            get { return this.GetLazyElement(By.CssSelector("#showDialog1"), "show dialog (1) button"); }
        }

        /// <summary>
        ///  LazyElement for dialog1 Box
        /// </summary>
        private LazyElement Dialog1
        {
            get { return this.GetLazyElement(By.CssSelector("#loading-div"), "Dialog 1: \"Loading\" box"); }
        }

        /// <summary>
        ///  LazyElement for dialog Message
        /// </summary>
        private LazyElement Dialog1Message
        {
            get { return this.GetLazyElement(By.CssSelector("#PleaseWaitText"), "Please wait Message"); }
        }

        /// <summary>
        ///  LazyElement for dialog dismiss button
        /// </summary>
        private LazyElement CloseDialogButton
        {
            get { return this.GetLazyElement(By.CssSelector("#CloseButtonShowDialog"), "Close button on dialog (1)"); }
        }

        /// <summary>
        ///  Open Dialog 1
        /// </summary>
        public void OpenDialog1()
        {
            this.ShowDialog1Button.Click();
        }

        /// <summary>
        ///  Return message Test in Dialog 1
        /// </summary>
        public string GetDialog1Text()
        {
            return this.Dialog1Message.Text;
        }

        /// <summary>
        ///  Open Dialog 1
        /// </summary>
        public void CloseDialog1()
        {
            this.CloseDialogButton.Click();
        }

        /// <summary>
        ///  Open Dialog 1
        /// </summary>
        public bool Dialog1IsDisplayed()
        {
            return this.Dialog1.Displayed;
        }
    }
}