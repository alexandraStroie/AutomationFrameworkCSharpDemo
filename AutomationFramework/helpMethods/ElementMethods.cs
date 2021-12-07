using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.helpMethods
{
    public class ElementMethods
    {

        public IWebDriver Driver { get; private set; }

        public ElementMethods(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        public void ClickElement(By element)
        {
            Driver.FindElement(element).Click();
        }

        public void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public void HooverElement(By element)
        {
            Actions hoover = new Actions(Driver);
            hoover.MoveToElement(Driver.FindElement(element)).Build().Perform();
        }


        public void ScrollElement(By element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", Driver.FindElement(element));
        }

        public void FillElement(By element, string message) 
        {
            Driver.FindElement(element).SendKeys(message);
        }

        public void selectElementByValue(By element, string value) 
        {
            SelectElement selectElement = new SelectElement(Driver.FindElement(element));
            selectElement.SelectByValue(value);
        }


        public void validateText(By element, string text)
        {
            Assert.IsTrue(text.Equals(Driver.FindElement(element).Text));
        }
    }
}
