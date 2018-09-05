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
    class TestBase
    {
        protected IWebDriver driver = null;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            //IWebDriver driver = new FirefoxDriver();        
            driver.Navigate().GoToUrl("http://www.automationpractice.com");

        }
        
      [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();

        }


    }
}
