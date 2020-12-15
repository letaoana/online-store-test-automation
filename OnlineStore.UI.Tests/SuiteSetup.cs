using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System.IO;

namespace OnlineStore.UI.Tests
{
    [SetUpFixture]
    public static class SuiteSetup
    {        
        public static ExtentReports extent;

        [OneTimeSetUp]
        public static void Initialize()
        {
            extent = new ExtentReports();
            extent.AttachReporter(new ExtentHtmlReporter(Path.Combine(Directory.GetCurrentDirectory(), @"ExtentReports\")));
        }

        [OneTimeTearDown]
        public static void CleanUp()
        {
            //extent.Flush();
        }
    }
}
