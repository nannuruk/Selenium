using Day1_demo.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day1_demo
{
    class Program
    {

       static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new FirefoxDriver();        
            driver.Navigate().GoToUrl("http://www.automationpractice.com");

            //driver.FindElement(By.XPath("//*[@class='login']")).Click();


            IndexPage ip = new IndexPage(driver);
            ip.clickSignInLink();


            SignIn si = new SignIn(driver);
            si.enterRegisteredEmailAddress("nannuruk30@gmail.com");
            si.enterPassword("Automation123");
            si.clickSignIn();

            Assert.IsTrue(si.isAuthenticationFailedDisplayed());

            MyAccount myacc = new MyAccount(driver);
            Assert.IsFalse(myacc.isAuthenticationSuccessful());

            myacc.hoverShoppingCart();
            myacc.openCart();


            Thread.Sleep(5000);
            driver.Close();
            driver.Quit();  

        }
    }
}
