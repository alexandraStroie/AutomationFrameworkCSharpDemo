
using System;
using System.IO;
using System.Runtime.InteropServices;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;

namespace AutomationFramework.extentUtility
{
    public class ExtentReport
    {
        public ExtentHtmlReporter HTMLReporter { get; private set;}
        public ExtentReports ExtReport { get; set; }
        public ExtentTest ExtTest { get; set; }
        public string ProjectDirectory { get; set; }
        public string ReportDirectory { get; set; }

        public ExtentReport(string ReportName)
        {
            string pathR = AppDomain.CurrentDomain.BaseDirectory;
            ProjectDirectory = Directory.GetParent(pathR).Parent.Parent.FullName + "\\";
            ReportDirectory = ProjectDirectory + "\\reports\\";

            cleanOldReports(ReportName);

            HTMLReporter = new ExtentHtmlReporter(ReportDirectory);
            HTMLReporter.LoadConfig(ProjectDirectory + "extent-config.xml");

            ExtReport = new ExtentReports();
            ExtReport.AttachReporter(HTMLReporter);

            ExtTest = ExtReport.CreateTest("startTest " + ReportName);

        }

        public void cleanOldReports(string ReportName)
        {
            string[] FilesReports = Directory.GetFiles(ReportDirectory);

            foreach (var file in FilesReports) {
                
                if (file.Contains(ReportName)) {
                    File.Delete(file);
                }
            }
        }


        public string screenshot(IWebDriver driver)
        {
            return ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString; 
        }

        public void entryReport(string entryType, string message, [Optional]IWebDriver driver)
        {
            switch (entryType) 
            {
                case "info":
                    ExtTest.Log(Status.Info, message);
                    break;
                case "pass":
                    ExtTest.Log(Status.Pass, message);
                    break;
                case "failed":
                    ExtTest.Fail(message, MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot(driver)).Build() );
                    break;
            }
        }

        public void GenerateReport()
        {
            ExtReport.Flush();
        }
    }
}
