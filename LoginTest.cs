using Day1_demo.Enums;
using Day1_demo.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_demo.Tests
{
    class LoginTest : TestBase
    {

        [Test]
        public void Login()
        {
            //driver.FindElement(By.XPath("//*[@class='login']")).Click();

            IndexPage ip = new IndexPage(driver);
            ip.clickSignInLink();            

            SignIn si = new SignIn(driver);
            si.enterRegisteredEmailAddress("nannuruk30@gmail.com");
            si.enterPassword("Automation123");
            si.clickSignIn();

            Assert.IsFalse(si.isAuthenticationFailedDisplayed());

            MyAccount myacc = new MyAccount(driver);
            Assert.IsTrue(myacc.isAuthenticationSuccessful());

            
        }

        [Test]
        public void invalidLogin()
        {
            //driver.FindElement(By.XPath("//*[@class='login']")).Click();

            IndexPage ip = new IndexPage(driver);
            ip.clickSignInLink();
            
            SignIn si = new SignIn(driver);
            si.enterRegisteredEmailAddress("nannuruk30@gmail.com");
            si.enterPassword("Automation12");
            si.clickSignIn();

            Assert.IsTrue(si.isAuthenticationFailedDisplayed());

            MyAccount myacc = new MyAccount(driver);
            Assert.IsFalse(myacc.isAuthenticationSuccessful());

            ip.hoverCategory(Category.Women);
            ip.openSubCategory("Evening Dresses");
                        
        }

    }
}
