using AutomationFramework.BaseData;
using AutomationFramework.pages;
using NUnit.Framework;


namespace AutomationFramework.Tests
{
    public class WindowsTest : BaseTest
    {
        public WindowsPage WindowsPage { get; private set; }
        public IndexPage IndexPage { get; private set; }
        public RegisterPage RegisterPage { get; private set; }


        [Test]
        public void WindowsTestMethod()
        {

            WindowsPage = new WindowsPage(Driver);
            IndexPage = new IndexPage(Driver);
            RegisterPage = new RegisterPage(Driver);


            //validam pagina
            IndexPage.ValidateIndexPage();

            // identificam signin
            IndexPage.clickSkipSignIn();

            RegisterPage.NavigateToWindowPage();

            WindowsPage.TabInteraction();

            WindowsPage.WindowInteraction();

            WindowsPage.MltipleTabInteraction();

        }
    }
}
