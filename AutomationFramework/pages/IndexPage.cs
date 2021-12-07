
using AutomationFramework.helpMethods;
using OpenQA.Selenium;

namespace AutomationFramework.pages
{
    public class IndexPage
    {
        public IWebDriver Driver { get; private set; }
        public ElementMethods EMethods { get; private set; }
        public PageMethods PageMet { get; private set; }
        public IndexPage(IWebDriver Driver) 
        {
            this.Driver = Driver;
            EMethods = new ElementMethods(Driver);
            PageMet = new PageMethods(Driver);
        }

        private By SkipSignInElement => By.Id("btn2");
        private By SignInElement => By.Id("btn1");

        public RegisterPage clickSkipSignIn() 
        {
            EMethods.ClickElement(SkipSignInElement);
            return new RegisterPage(Driver);
        }


        public IndexPage ValidateIndexPage()
        {
            PageMet.ValidatePage("Index");
            return this;
        }

    }
}
