using AutomationFramework.BaseData;
using AutomationFramework.helpMethods;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationFramework.Tests
{
    public class SigninTest : BaseTest
    {
        public PageMethods PMethods { get; private set; }
        public ElementMethods EMethods { get; private set; }

        [Test]
        public void TestSignInMethod()
        {
            EMethods = new ElementMethods(Driver);
            PMethods = new PageMethods(Driver);

            //validam pagina
            string expectedIndexPage = "Index";
            PMethods.ValidatePage(expectedIndexPage);

            // identificam signin
            IWebElement signinElement = Driver.FindElement(By.Id("btn1"));
            signinElement.Click();
           
            string expectedSignInPage = "SignIn";
            PMethods.ValidatePage(expectedSignInPage);


            IWebElement emailElement = Driver.FindElement(By.CssSelector("input[placeholder='E mail']"));
            //IWebElement emailElement = Driver.FindElement(By.XPath("//input[@placeholder='E mail']"));
            string emailValue = "alexandra.str@gmail.com";
            emailElement.SendKeys(emailValue);

            IWebElement passwordElement = Driver.FindElement(By.XPath("//input[@placeholder='Password']"));
            string passwordValue = "Password123#";
            passwordElement.SendKeys(passwordValue);

            IWebElement enterBtnElement = Driver.FindElement(By.Id("enterbtn"));
            enterBtnElement.Click();

            //validam mesajul
            string expectedMessage = "Invalid User Name or PassWord";
            EMethods.validateText(By.Id("errormsg"), expectedMessage);

            
        }
    }
}
