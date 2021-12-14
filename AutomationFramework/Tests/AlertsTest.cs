
using AutomationFramework.BaseData;
using AutomationFramework.pages;
using NUnit.Framework;


namespace AutomationFramework.Tests
{
    public class AlertsTest : Hooks
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
            ExtReport.entryReport("pass","validate index page");

            // identificam signin
            IndexPage.clickSkipSignIn();
            ExtReport.entryReport("pass", "clicked on skip signin");


            RegisterPage.NavigateToAlertPage();

            AlertPage.AcceptAlert();
            ExtReport.entryReport("pass", "accept alert");

            AlertPage.CancelAlert();
            ExtReport.entryReport("pass", "cancel alert");

            AlertPage.FillMessageAlert("My message");
            ExtReport.entryReport("pass", "fill alert with message");


        }
    }
}
