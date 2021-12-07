

using AutomationFramework.helpMethods;
using OpenQA.Selenium;

namespace AutomationFramework.pages
{
    public class WindowsPage
    {
        public IWebDriver Driver { get; private set; }
        public ElementMethods EMethods { get; private set; }
        public WindowsMethods WMethods { get; private set; }
        public WindowsPage(IWebDriver Driver)
        {
            this.Driver = Driver;
            EMethods = new ElementMethods(Driver);
            WMethods = new WindowsMethods(Driver);
        }


        private By TabList => By.CssSelector("ul[class*='nav-tabs'] li a");
        private By BtnHeaderElement => By.CssSelector("#Tabbed button");
        private By BtnWindowElement => By.CssSelector("#Seperate button");
        private By MultipleWindowElement => By.CssSelector("#Multiple button");


        public void TabInteraction() 
        {
            EMethods.ClickElement(Driver.FindElements(TabList)[0]);
            EMethods.ClickElement(BtnHeaderElement);

            WMethods.SwotchToSpecificTabIndex(1);
            WMethods.DriverClose();
            WMethods.SwotchToSpecificTabIndex(0);

        }


        public void WindowInteraction()
        {
            EMethods.ClickElement(Driver.FindElements(TabList)[1]);
            EMethods.ClickElement(BtnWindowElement);

            WMethods.SwotchToSpecificTabIndex(1);
            WMethods.DriverClose();
            WMethods.SwotchToSpecificTabIndex(0);
        }


        public void MltipleTabInteraction()
        {

            EMethods.ClickElement(Driver.FindElements(TabList)[2]);
            EMethods.ClickElement(MultipleWindowElement);

            WMethods.SwotchToSpecificTabIndex(2);
            WMethods.DriverClose();
            WMethods.SwotchToSpecificTabIndex(1);
            WMethods.DriverClose();
            WMethods.SwotchToSpecificTabIndex(0);
        }
    }
}
