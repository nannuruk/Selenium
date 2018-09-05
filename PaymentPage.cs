using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day1_demo.Pages
{
    class PaymentPage
    {

        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'I confirm my order')]")]
        IWebElement _confirmOrder;

        public PaymentPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void clickConfirmOrder()
        {
            //Thread.Sleep(8000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(_confirmOrder));

           _confirmOrder.Click();
        }
    }
}
