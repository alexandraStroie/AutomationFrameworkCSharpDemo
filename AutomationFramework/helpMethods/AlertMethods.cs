using System;
using OpenQA.Selenium;

namespace AutomationFramework.helpMethods
{
    public class AlertMethods
    {
        public IWebDriver Driver { get; private set; }

        public AlertMethods(IWebDriver Driver)
        {
            this.Driver = Driver;
        }


        public void AcceptAlert()
        {
            var alertOk = Driver.SwitchTo().Alert();
            Console.WriteLine(alertOk.Text);
            alertOk.Accept();
        }

        public void DismissAlert()
        {
            var alertOk = Driver.SwitchTo().Alert();
            Console.WriteLine(alertOk.Text);
            alertOk.Dismiss();
        }


        public void FillAlertMessage(string message)
        {
            var alertTextBox = Driver.SwitchTo().Alert();
            Console.WriteLine(alertTextBox.Text);
            alertTextBox.SendKeys(message);
            alertTextBox.Accept();
        }
    }
}
