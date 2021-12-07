using System;
using OpenQA.Selenium;

namespace AutomationFramework.helpMethods
{
    public class WindowsMethods
    {
        public IWebDriver Driver { get; private set; }

        public WindowsMethods(IWebDriver Driver) 
        {
            this.Driver = Driver;
        }

        public void SwotchToSpecificTabIndex(int index) 
        {
            Driver.SwitchTo().Window(Driver.WindowHandles[index]);
            Console.WriteLine("Titlu initial" + Driver.Title);
        }

        public void DriverClose() 
        {
            Driver.Close();
        }
    }
}
