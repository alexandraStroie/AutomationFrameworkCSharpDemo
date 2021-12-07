using AutomationFramework.helpMethods;
using OpenQA.Selenium;

namespace AutomationFramework.pages
{
    public class FramePage
    {
        public IWebDriver Driver { get; private set; }
        public ElementMethods EMethods { get; private set; }
        public FrameMethods FMethods { get; private set; }
        public FramePage(IWebDriver Driver)
        {
            this.Driver = Driver;
            EMethods = new ElementMethods(Driver);
            FMethods = new FrameMethods(Driver);
        }

        private By InputSingleFrameElement => By.CssSelector("input[type = 'text']");
        private By MultipleFrameTabElement => By.CssSelector("a[href='#Multiple']");
        private By MultipleFrameElement => By.CssSelector("iframe[src='MultipleFrames.html']");
        private By SingleFrameElement => By.CssSelector("iframe[src='SingleFrame.html']");
        private By InputMultipleFrameElement => By.CssSelector("input[type = 'text']");


        public void singleFrameInteraction(string value) 
        {
            FMethods.SwitchToFrameElement("singleframe");

            EMethods.FillElement(InputSingleFrameElement, value);

            // get out of frame
            FMethods.SwitchToDefalutFrame();
        }


        public void multipleFrameInteraction(string value) 
        {
            EMethods.ClickElement(MultipleFrameTabElement);
            FMethods.SwitchToFrameElement(MultipleFrameElement);
            FMethods.SwitchToFrameElement(SingleFrameElement);
            EMethods.FillElement(InputMultipleFrameElement, value);
        }

    }
}
