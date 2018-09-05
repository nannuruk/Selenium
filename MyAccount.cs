using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day1_demo.Pages
{
    class MyAccount
    {
        IWebDriver driver;

        [FindsBy(How=How.XPath, Using = "//a[@title='View my customer account']")]
        IWebElement _userName;

        [FindsBy(How = How.XPath, Using = "//div[@style='display: block;']//a[@title='Check out']")]
        IWebElement _checkOutCartButton;

        
        public MyAccount(IWebDriver driver)
        {
          this.driver = driver;
          PageFactory.InitElements(driver,this);
        }

        public Boolean isAuthenticationSuccessful()
        {
            try
            {
                return _userName.Displayed;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


        public void hoverShoppingCart()
        {
            // _checkOut.Click();
            //Thread.Sleep(4000);
            Actions action = new Actions(driver);
            IWebElement _cart = driver.FindElement(By.XPath("//a[@title='View my shopping cart']")); 
            action.MoveToElement(_cart).Perform();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(_checkOutCartButton));
        }

        public void openCart()
        {            
           // wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(this.checkOut)));
           _checkOutCartButton.Click();
        }

        internal void hoverCart(object cart)
        {
            throw new NotImplementedException();
        }
    }
}
