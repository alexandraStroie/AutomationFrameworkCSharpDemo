
using AutomationFramework.BaseData;
using AutomationFramework.pages;
using NUnit.Framework;


namespace AutomationFramework.Tests
{
    public class FrameTest : Hooks
    {
        public IndexPage IndexPage { get; private set; }
        public RegisterPage RegisterPage { get; private set; }
        public FramePage FramePage { get; private set; }

        [Test]
        public void FrameTestMethod()
        {
            IndexPage = new IndexPage(Driver);
            RegisterPage = new RegisterPage(Driver);
            FramePage = new FramePage(Driver);

            //validam pagina
            IndexPage.ValidateIndexPage();

            // identificam signin
            IndexPage.clickSkipSignIn();

            RegisterPage.NavigateToFramePage();

            // GO TO iFRAME
            FramePage.singleFrameInteraction(Resource.GetValue("SingleFrameValue"));

            FramePage.multipleFrameInteraction(Resource.GetValue("MultipleFrameValue"));
            
        }
    }
}
