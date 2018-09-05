using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Day1_demo.StepDefinitions
{
    [Binding]
    public class BaseStep
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        static ExtentReports extent;
        static protected ExtentTest test;

        public static IWebDriver driver = null;

        [BeforeTestRun]
        static public void testRunBefore()
        {
            extent = new ExtentReports("C:\\Users\\NannuruK\\Desktop\\Krishna-Personal\\ReportsSelenium");
        }

        [BeforeScenario]
        static public void BeforeScenario()
        {
            test = extent.StartTest("Test Name", "Sample description");
            driver = new ChromeDriver();
        }

        [AfterScenario]
        static public void AfterScenario()
        {
            driver.Close();
            extent.EndTest(test);
        }

        [AfterTestRun]
        static public void testRunAfter()
        {
            extent.Flush();
            extent.Close();
        }
    }
}
