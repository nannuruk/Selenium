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
    class AddressPage
    {
        IWebDriver driver;

        [FindsBy(How=How.XPath, Using = "//input[@id='firstname']")]
        IWebElement _firstName;

        [FindsBy(How = How.XPath, Using = "//input[@id='lastname']")]
        IWebElement _lastName;

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

        [FindsBy(How = How.XPath, Using = "//button[@id='submitAddress']")]
        IWebElement _submitAddress;

        [FindsBy(How = How.XPath, Using = "//li[contains(text(), 'The Zip/Postal code you')]")]
        IWebElement _postalCodeValidationMsg;

        public AddressPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }
   
        public void enterFirstName(String FName)
        {
            _firstName.SendKeys(FName);
        }

        public void enterLastName(String LName)
        {
            _lastName.SendKeys(LName);
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

        public void clickSaveAddress()
        {
            _submitAddress.Click();
        }

        public bool isZipValidationMsgDisplayed()
        {
            Thread.Sleep(4000);
            return _postalCodeValidationMsg.Displayed;
        }
    }
}
