using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day1_demo.Pages
{
    class OrderConfirmationPage
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='box']//strong[@class='dark']")]
        IWebElement _orderConfirmationMessagedSuccess;


        public OrderConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        public Boolean isOrderConfirmationSuccessDisplayed()
        {
            try
            {
                Thread.Sleep(8000);
                return _orderConfirmationMessagedSuccess.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }



    }
}
