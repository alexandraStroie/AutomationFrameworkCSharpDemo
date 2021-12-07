
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework.BaseData
{
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        [SetUp]
        public void PrepareDriver() 
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demo.automationtesting.in/Index.html");
        }

        [TearDown]
        public void QuitDriver()
        {
            Driver.Quit();
        }
    }
}
