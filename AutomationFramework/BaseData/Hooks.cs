using AutomationFramework.extentUtility;
using AutomationFramework.resourceUtility;
using NUnit.Framework;

namespace AutomationFramework.BaseData
{
    public class Hooks : BaseTest
    {

        public ExtentReport ExtReport { get; set; }
        public ResourceUtility Resource { get; private set; }

        [SetUp]
        public void initiateTest()
        {
            PrepareDriver();
                
            var TestName = GetType().Name;

            Resource = new ResourceUtility($"tests.{TestName}");

            ExtReport = new ExtentReport(TestName);
        }
        
        
        [TearDown]
        public void QuitDriver()
        {
            var TestResult = TestContext.CurrentContext.Result.Outcome.Status.ToString();

            if (TestResult.Equals("Failed")) {
                ExtReport.entryReport("failed", TestContext.CurrentContext.Result.Message.ToString(),Driver);
            }

            ExtReport.GenerateReport();
            Driver.Quit();
        }
    }
}
