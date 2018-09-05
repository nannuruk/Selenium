using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Demo1.Pages
{
    class CategoryPage
    {
        //IWebElement womenCategory;
        //IWebElement womenTops;
        //IWebElement womenDresses;

        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'Add to cart')]")]
        IWebElement _addToCart;

        [FindsBy(How = How.XPath, Using = "//a[@title='Proceed to checkout']")]
        IWebElement _proceedToCO;

        [FindsBy(How = How.XPath, Using = "//ul[@class='product_list grid row']/li[1]/div[@class='product-container']")]
        IWebElement _product;

        public CategoryPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void hoverProduct()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(_product).Build().Perform();
        }

        public void clickaddToCart()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(_addToCart));

            _addToCart.Click();
        }

        public void clickProceedToCO()
        {
            Thread.Sleep(4000);
            _proceedToCO.Click();
        }

        public void chooseWomenView()
        {
        }

        public void clickWomenCompare()
        {
        }
    }

}
