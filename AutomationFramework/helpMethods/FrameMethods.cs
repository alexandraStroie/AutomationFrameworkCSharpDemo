using OpenQA.Selenium;

namespace AutomationFramework.helpMethods
{
    public class FrameMethods
    {
        public IWebDriver Driver { get; private set; }

        public FrameMethods(IWebDriver Driver)
        {
            this.Driver = Driver;
        }


        public void SwitchToFrameElement(string element)
        {
            Driver.SwitchTo().Frame(element);
        }

        public void SwitchToFrameElement(By element)
        {
            Driver.SwitchTo().Frame(Driver.FindElement(element));
        }

        public void SwitchToDefalutFrame()
        {
            Driver.SwitchTo().DefaultContent();
        }
    }
}
