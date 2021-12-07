
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationFramework.helpMethods
{
    public class PageMethods
    {
        public IWebDriver Driver { get; private set; }

        public PageMethods(IWebDriver Driver)
        {
            this.Driver = Driver;
        }

        public void ValidatePage(string expectedPage)
        {
            string actualIndexPage = Driver.Title;
            Assert.AreEqual(expectedPage, actualIndexPage, $"Pagina {expectedPage} nu a aparut");
        }


        public void NavigateToURL(string url)
        {
            Driver.Navigate().GoToUrl(url);

        }
    }
}
