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
    class NewSignInUser : TestBase
    {

        [Test]
        public void ValidNewSignInUser()
        {
            //driver.FindElement(By.XPath("//*[@class='login']")).Click();

            IndexPage ip = new IndexPage(driver);

            String emailAddress = "krishna01" + DateTime.Now.ToString("HHmmss") + "@xyz.com";

            ip.hoverCategory(Category.Women);
            ip.openSubCategory("Evening Dresses");

            CategoryPage cat = new CategoryPage(driver);
            cat.hoverProduct();
            cat.clickaddToCart();
            cat.clickProceedToCO();

            OrderPage op = new OrderPage(driver);
            op.clickProceedToCO();

            SignIn si = new SignIn(driver);
            si.enterEmailAddress(emailAddress);
            si.clickCreateAccount();

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
            aap.enterAlias("Doc"+ DateTime.Now.ToString("HH:mm:ss"));
            aap.clickRegisterAddress();

            op.clickProceedToCheckOut();
            op.clickTermsofService();

            op.clickProceedToCheckOut();

            PaymentPage pp = new PaymentPage(driver);

            op.clickPayByBankWire();
            pp.clickConfirmOrder();



        }

    }
}
