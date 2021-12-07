
using AutomationFramework.BaseData;
using AutomationFramework.pages;
using NUnit.Framework;

namespace AutomationFramework.Tests
{
    public class RegisterTest : BaseTest
    {
        public IndexPage IndexPage { get; private set; }
        public RegisterPage RegisterPage { get; private set; }

        [Test]
        public void TestRegisterMethod() 
        {

            IndexPage = new IndexPage(Driver);
            RegisterPage = new RegisterPage(Driver);

            //validam pagina
            IndexPage.ValidateIndexPage();
                
            // identificam signin
            IndexPage.clickSkipSignIn();

            RegisterPage.FillFirstName("Alex");

            //Interactionam cu un dropdown
            RegisterPage.SelectSkills("Java");

            RegisterPage.SelectYear("1990");

            //scroll element into view - actions = simulam actiuni la nivel de mouse
            RegisterPage.HooverSubmit();

            RegisterPage.SelectLanguage("Spanish");

            RegisterPage.ClickFirstName();

            RegisterPage.ClickCountry();

            RegisterPage.FillCountryNameAndSubmit("India");

            RegisterPage.FillLastName("Peterson");

            RegisterPage.FillAddress("5th avenue");

            RegisterPage.FillEmail("alstr@mailinator.com");

            RegisterPage.FillPhone("0745668659");

            RegisterPage.ClickGenderElementFemale();

            RegisterPage.ClickHobbyElement();

            RegisterPage.SelectDay("18");

            RegisterPage.FillFirstPassword("Password123#");

            RegisterPage.FillConfirmationPassword("Password123#");

            RegisterPage.ClickOnSubmitButton();
               

        }

    }
}
