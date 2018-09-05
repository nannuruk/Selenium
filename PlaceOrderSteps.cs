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
    public sealed class PlaceOrderSteps : BaseStep
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        
        SignIn si;
        OrderPage op;

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

        [Given(@"I enter '(.*)' and '(.*)'")]
        public void GivenIEnterAnd(string p0, string p1)
        {
            si = new SignIn(driver);
            si.enterRegisteredEmailAddress(p0);
            si.enterPassword(p1);
            si.clickSignIn();
        }

        [Given(@"I enter Add a new address")]
        public void GivenIEnterAddANewAddress()
        {
            AddressPage ap = new AddressPage(driver);
            ap.enterFirstName("Krish");
            ap.enterLastName("Krishna");
            ap.enterAddress1("45 Pinnaker St");
            ap.enterCity("Atlanta");
            ap.enterIdState("Alaska");
            ap.enterPostCode("11111");
            ap.enterCountry("United States");
            ap.enterPhone("1111111111");
            ap.enterPhoneMobile("3333333333333");
            ap.enterAlias("Hema");
            ap.clickSaveAddress();
        }

        [When(@"I go to Order page to Proceed to checkout")]
        public void WhenIGoToOrderPageToProceedToCheckout()
        {
            op.clickProceedToCO();
            op.clickTermsofService();
        }

        [Then (@"I go to Pay Bank Wire")]
        public void WhenIGoToPayBankWire()
        {
            PaymentPage pp = new PaymentPage(driver);
            pp.clickConfirmOrder();
        }
    }
}
