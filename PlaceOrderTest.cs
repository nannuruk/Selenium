using Day1_demo.Enums;
using Day1_demo.Pages;
using Demo1.Pages;
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
    class PlaceOrderTest : TestBase
    {

        [Test]
        public void PlaceOrder()
        {
            //driver.FindElement(By.XPath("//*[@class='login']")).Click();

            IndexPage ip = new IndexPage(driver);
            ip.clickSignInLink();
            
            SignIn si = new SignIn(driver);
            si.enterRegisteredEmailAddress("nannuruk30@gmail.com");
            si.enterPassword("Automation123");
            si.clickSignIn();
            
            ip.hoverCategory(Category.Women);
            ip.openSubCategory("Evening Dresses");

            CategoryPage cat = new CategoryPage(driver);
            cat.hoverProduct();
            cat.clickaddToCart();
            cat.clickProceedToCO();

            OrderPage op = new OrderPage(driver);
            op.clickProceedToCO();
            op.clickNewAddress();

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

            op.clickProceedToCO();
            op.clickTermsofService();

            op.clickProceedToCO();

            PaymentPage pp = new PaymentPage(driver);
            pp.clickConfirmOrder();



        }

    }
}
