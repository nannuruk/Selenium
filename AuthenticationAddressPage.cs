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
    class AuthenticationAddressPage
    {

        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@class='account_creation']//div[@class='clearfix']")]
        IWebElement _title;

        [FindsBy(How = How.XPath, Using = "//input[@id='customer_firstname']")]
        IWebElement _customerFirstName;

        [FindsBy(How = How.XPath, Using = "//input[@id='customer_lastname']")]
        IWebElement _customerLastName;

        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        IWebElement _customerEmail;

        [FindsBy(How = How.XPath, Using = "//input[@id='passwd']")]
        IWebElement _customerPWD;

        [FindsBy(How = How.XPath, Using = "//input[@id='firstname']")]
        IWebElement _firstname;

        [FindsBy(How = How.XPath, Using = "//input[@id='lastname']")]
        IWebElement _lastname;

        [FindsBy(How = How.XPath, Using = "//input[@id='company']")]
        IWebElement _company;

        [FindsBy(How = How.XPath, Using = "//input[@id='address1']")]
        IWebElement _address1;

        [FindsBy(How = How.XPath, Using = "//input[@id='address2']")]
        IWebElement _address2;

        [FindsBy(How = How.XPath, Using = "//input[@id='city']")]
        IWebElement _city;

        [FindsBy(How = How.XPath, Using = "//select[@id='id_state']")]
        IWebElement _state;

        [FindsBy(How = How.XPath, Using = "//input[@id='postcode']")]
        IWebElement _postCode;

        [FindsBy(How = How.XPath, Using = "//select[@id='id_country']")]
        IWebElement _country;

        [FindsBy(How = How.XPath, Using = "//input[@id='phone']")]
        IWebElement _phone;

        [FindsBy(How = How.XPath, Using = "//input[@id='phone_mobile']")]
        IWebElement _phoneMobile;

        [FindsBy(How = How.XPath, Using = "//input[@id='other']")]
        IWebElement _other;

        [FindsBy(How = How.XPath, Using = "//input[@id='alias']")]
        IWebElement _alias;

        [FindsBy(How = How.XPath, Using = "//button[@id='submitAccount']")]
        IWebElement _registerAddress;

        [FindsBy(How = How.XPath, Using = "//li[contains(text(), 'The Zip/Postal code you')]")]
        IWebElement _postalCodeValidationMsg;

        public AuthenticationAddressPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void enterTitle()
        {
            _title.Click();
        }

        public void enterFirstName(String FirstName)
        {
            Thread.Sleep(5000);
            _customerFirstName.SendKeys(FirstName);
        }

        public void enterLastName(String LastName)
        {
            _customerLastName.SendKeys(LastName);
        }

        public void enterEmailAddress(String newEmailAddress)
        {
            _customerEmail.Clear();
            _customerEmail.SendKeys(newEmailAddress);
        }

        public void enterPassWord(String newPWD)
        {
            // Thread.Sleep(4000);
            _customerPWD.Clear();
            _customerPWD.SendKeys(newPWD);
        }

        public void enterFName(String FName)
        {
            //Thread.Sleep(5000);
            _firstname.SendKeys(FName);
        }

        public void enterLName(String LName)
        {
            _lastname.SendKeys(LName);
        }


        public void enterCompany()
        {
        }

        public void enterAddress1(String address)
        {
            _address1.SendKeys(address);
        }

        public void enterAddress2()
        {
        }

        public void enterCity(String city)
        {
            _city.SendKeys(city);
        }

        public void enterIdState(String state)
        {
            SelectElement sel = new SelectElement(_state);
            sel.SelectByText(state);
        }

        public void enterPostCode(String postcode)
        {
            _postCode.SendKeys(postcode);
        }

        public void enterCountry(String country)
        {
            SelectElement sel = new SelectElement(_country);
            sel.SelectByText(country);
        }

        public void enterPhone(String homePhone)
        {
            _phone.SendKeys(homePhone);
        }

        public void enterPhoneMobile(String mobile)
        {
            _phoneMobile.SendKeys(mobile);
        }

        public void enterOther()
        {
        }

        public void enterAlias(String alias)
        {
            _alias.SendKeys(alias);
        }

        public void clickRegisterAddress()
        {
            _registerAddress.Click();
        }

        public bool isZipValidationMsgDisplayed()
        {
            Thread.Sleep(4000);
            return _postalCodeValidationMsg.Displayed;
        }
    }
}
