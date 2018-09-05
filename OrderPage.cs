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
    class OrderPage
    {
        IWebDriver driver;

        [FindsBy(How=How.CssSelector, Using= "[class='label label-success']")]
        IWebElement _inStock;

        [FindsBy(How = How.XPath, Using = "//div[@class='cart_quantity_button clearfix']//a[@title='Add']")]
        IWebElement _addSelected;

        [FindsBy(How = How.XPath, Using = "//div[@class='cart_quantity_button clearfix']//a[@title='Subtract']")]
        IWebElement _removeSelected;

        [FindsBy(How = How.XPath, Using = "//div[@id='center_column']//a[@title='Proceed to checkout']")]
        IWebElement _proceedtoCO;

        [FindsBy(How = How.XPath, Using = "//div[@id='center_column']//span[contains(text(), 'Proceed to checkout')]")]
        IWebElement _ProceedToCheckOut;

        [FindsBy(How = How.XPath, Using = "//a[@title='Add']")]
        IWebElement _newAddress;

        [FindsBy(How = How.XPath, Using = "//input[@id='cgv']")]
        IWebElement _termsOfService;

        [FindsBy(How = How.XPath, Using = "//a[@class='bankwire']")]
        IWebElement _payByBankWire;

        public OrderPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }
   
        public void clickInStock()
        {
            _inStock.Click();
        }

        public void clickAddSelected()
        {
            _addSelected.Click();
        }

        public void clickRemoveSelected()
        {
            _removeSelected.Click();
        }

        public void clickProceedToCO()
        {
            _proceedtoCO.Click();
        }

        public void clickNewAddress()
        {
            _newAddress.Click();
        }

        public void clickProceedToCheckOut()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            wait.Until(ExpectedConditions.ElementToBeClickable(_ProceedToCheckOut));

            _ProceedToCheckOut.Click();
        }

        public void clickTermsofService()
        {
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(80));
            // wait.Until(ExpectedConditions.ElementToBeClickable(_termsOfService));

            Thread.Sleep(5000);
            _termsOfService.Click();
        }

        public void clickPayByBankWire()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
            wait.Until(ExpectedConditions.ElementToBeClickable(_payByBankWire));

            _payByBankWire.Click();
        }


    }
}
