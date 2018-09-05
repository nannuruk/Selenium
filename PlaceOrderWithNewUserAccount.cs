using Day1_demo.Enums;
using Day1_demo.Pages;
using Demo1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Day1_demo.StepDefinitions
{
    [Binding]
    public sealed class PlaceOrderWithNewUserAccount : BaseStep
    {
        SignIn si;
        OrderPage op;
        PaymentPage pp;
        string emailAddress = "krishna01"+ DateTime.Now.ToString("HHmmss")+"@xyz.com";
       

        /*        [Given(@"I go to automationpractice website")]
                public void GivenIGoToAutomationpracticeWebsite()
                {
                    driver = new ChromeDriver();
                    //IWebDriver driver = new FirefoxDriver();        
                    driver.Navigate().GoToUrl("http://www.automationpractice.com");
                }

                [Given(@"I go to Womens and Evening Dresses section")]
                public void GivenIGoToWomensSection()
                {
                    IndexPage ip = new IndexPage(driver);
                    ip.hoverCategory(Category.Women);
                    ip.openSubCategory("Evening Dresses");
                }

                [Given(@"I go to Cateogry page to Add to Cart")]
                public void GivenIGoToCateogryPageToAddToCart()
                {
                    CategoryPage cat = new CategoryPage(driver);
                    cat.hoverProduct();
                    cat.clickaddToCart();
                    cat.clickProceedToCO();
                }

                [Given(@"I go to Proceed to checkout on pop-up page")]
                public void GivenIGoToProceedToCheckoutOnPop_UpPage()
                {
                    op = new OrderPage(driver);
                    op.clickProceedToCO();
                }
        */

        [Given(@"I go to LogIn page")]
        public void GivenIGoToLogInPage()
        {
            si.enterEmailAddress(emailAddress);
            si.clickCreateAccount();
        }
        
        [When(@"I enter Add a new address")]
        public void WhenIEnterAddANewAddress()
        {
            AuthenticationAddressPage aap = new AuthenticationAddressPage(driver);
            aap.enterFirstName("aaaa");
            aap.enterLastName("bbbb");
            aap.enterEmailAddress(emailAddress);
            aap.enterPassWord("Testing11");
            aap.enterFName("");
            aap.enterLName("");
            aap.enterAddress1("55 Francis St");
            aap.enterCity("Arctic");
            aap.enterIdState("Alaska");
            aap.enterPostCode("22222");
            aap.enterCountry("United States");
            aap.enterPhone("1111111111");
            aap.enterPhoneMobile("3333333333333");
            aap.enterAlias("Doc" + DateTime.Now.ToString("HH: mm:ss"));
            aap.clickRegisterAddress();
        }

        [When(@"I go to Proceed to checkout on Order page")]
        public void WhenIGoToProceedToCheckoutOnOrderPage()
        {
            op.clickProceedToCheckOut();
            op.clickTermsofService();

            op.clickProceedToCheckOut();
        }

    }
}
