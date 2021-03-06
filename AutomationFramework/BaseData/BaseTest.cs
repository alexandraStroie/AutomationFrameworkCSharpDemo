
using AutomationFramework.resourceUtility;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework.BaseData
{
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }

        public void PrepareDriver() 
        {
            ResourceUtility resource = new ResourceUtility("driver.Driver"); 
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(resource.GetValue("URL"));
        }


    }
}

