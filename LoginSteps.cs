using Day1_demo.Pages;
using NUnit.Framework;
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
    public sealed class LoginSteps : BaseStep
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        SignIn si;

        [Given(@"I go to automationpractice website")]
        public void GivenIGoToAutomationpracticeWebsite()
        {

            //IWebDriver driver = new FirefoxDriver();        
            driver.Navigate().GoToUrl("http://www.automationpractice.com");
        }

        [Given(@"I go to SignIn page")]
        public void GivenIGoToSignInPage()
        {
            IndexPage ip = new IndexPage(driver);
            ip.clickSignInLink();
        }

        [When(@"I enter '(.*)' and '(.*)'")]
        public void WhenIEnterAnd(string p0, string p1)
        {
            si = new SignIn(driver);
            si.enterRegisteredEmailAddress(p0);
            si.enterPassword(p1);
            si.clickSignIn();
        }

        [Then(@"I should be naviagted to MyAccount page")]
        public void ThenIShouldBeNaviagtedToMyAccountPage()
        {
            Assert.IsFalse(si.isAuthenticationFailedDisplayed());

            MyAccount myacc = new MyAccount(driver);
            Assert.IsTrue(myacc.isAuthenticationSuccessful());

            test.Log(LogStatus.Pass, "Step details");

        }
    }
}
