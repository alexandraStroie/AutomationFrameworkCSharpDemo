using AutomationFramework.helpMethods;
using OpenQA.Selenium;

namespace AutomationFramework.pages
{
    public class AlertPage
    {
        public IWebDriver Driver { get; private set; }
        public ElementMethods EMethods { get; private set; }
        public AlertMethods AMethods { get; private set; }
        public AlertPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            EMethods = new ElementMethods(Driver);
            AMethods = new AlertMethods(Driver);
        }

        private By AlertOptionsElement => By.CssSelector(".nav-tabs.nav-stacked > li > a");
        private By AlertOkElement => By.CssSelector("#OKTab > button");
        private By AlertOkCancelElement => By.CssSelector("#CancelTab > button");
        private By AlertTextBoxElement => By.CssSelector("#Textbox > button");



        public AlertPage AcceptAlert()
        {
            EMethods.ClickElement(Driver.FindElements(AlertOptionsElement)[0]);
            EMethods.ClickElement(AlertOkElement);
            AMethods.AcceptAlert();
            return this;
        }


        public AlertPage CancelAlert()
        {
            EMethods.ClickElement(Driver.FindElements(AlertOptionsElement)[1]);
            EMethods.ClickElement(AlertOkCancelElement);
            AMethods.DismissAlert();
            return this;
        }


        public AlertPage FillMessageAlert(string message)
        {
            EMethods.ClickElement(Driver.FindElements(AlertOptionsElement)[2]);
            EMethods.ClickElement(AlertTextBoxElement);
            AMethods.FillAlertMessage(message);
            return this;
        }
    }
}
