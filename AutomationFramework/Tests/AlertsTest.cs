
using AutomationFramework.BaseData;
using AutomationFramework.pages;
using NUnit.Framework;


namespace AutomationFramework.Tests
{
    public class AlertsTest : BaseTest
    {
        public IndexPage IndexPage { get; private set; }
        public RegisterPage RegisterPage { get; private set; }
        public AlertPage AlertPage { get; private set; }

        [Test]
        public void TestAlertMethod()
        {

            IndexPage = new IndexPage(Driver);
            AlertPage = new AlertPage(Driver);
            RegisterPage = new RegisterPage(Driver);

            //validam pagina
            IndexPage.ValidateIndexPage();

            // identificam signin
            IndexPage.clickSkipSignIn();

            RegisterPage.NavigateToAlertPage();

            AlertPage.AcceptAlert();

            AlertPage.CancelAlert();

            AlertPage.FillMessageAlert("My message");


        }
    }
}
