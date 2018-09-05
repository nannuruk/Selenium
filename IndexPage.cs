using Day1_demo.Enums;
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
    class IndexPage
    {
        IWebDriver driver;

        [FindsBy(How=How.XPath, Using = "//*[@class='login']")]
        IWebElement _signInLink;

        [FindsBy(How = How.XPath, Using = "//a[@title='Women']")]
        IWebElement _womenCategory;

        String subCategory = "//ul[@style='display: block;']//a[@title='subCategory']";
                    
        public IndexPage(IWebDriver driver)
        {
          this.driver = driver;
          PageFactory.InitElements(driver,this);
        }
        
        public void clickSignInLink()
        {
            _signInLink.Click();

        }

        public void hoverCategory(Category category)
        {
            Thread.Sleep(4000);
            Actions action = new Actions(driver);

            switch (category)
            {
                case Category.Women:
                    action.MoveToElement(_womenCategory).Build().Perform();
                    // Thread.Sleep(4000);
                    
                    //_womenCategory;
                    break;
                case Category.Men:
                    //_menCategory.Click();
                    break;
                case Category.Dresses:
                    //_dressedCategory.Click();
                    break;

                default:break;
            }

        }

        public void openSubCategory(String subCategory)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            this.subCategory = this.subCategory.Replace("subCategory", "Evening Dresses");
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(this.subCategory)));
            driver.FindElement(By.XPath(this.subCategory)).Click();
        }

        }
}
