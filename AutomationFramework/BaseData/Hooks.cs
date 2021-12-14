using AutomationFramework.extentUtility;
using NUnit.Framework;

namespace AutomationFramework.BaseData
{
    public class Hooks : BaseTest
    {

        public ExtentReport ExtReport { get; set; }


        [SetUp]
        public void initiateTest()
        {
            PrepareDriver();

            var TestName = GetType().Name;

            ExtReport = new ExtentReport(TestName);
        }
        
        
        [TearDown]
        public void QuitDriver()
        {
            ExtReport.GenerateReport();
            Driver.Quit();
        }
    }
}
