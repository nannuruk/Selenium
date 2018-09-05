using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_demo.Pages
{
    class SignIn
    {
        IWebDriver driver;

        [FindsBy(How=How.XPath,Using="//input[@id='email_create']")]
        IWebElement _emailAddress;
        
        [FindsBy(How=How.Id,Using = "SubmitCreate")]
        IWebElement _createAccount;

        [FindsBy(How = How.XPath, Using = "//input[@id='email']")]
        IWebElement _registeredEmailAddress;

        [FindsBy(How=How.CssSelector, Using = "input[data-validate=isPasswd]")]
        IWebElement _password;

        [FindsBy(How=How.LinkText, Using = "Forgot your password?")]
        IWebElement _forgotYourPassword;

        [FindsBy(How=How.CssSelector, Using = "[class='button btn btn-default button-medium']")]
        IWebElement _signIn;

        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'Authentication')]")]
        IWebElement _errorMessageAuthenticationFailed;

        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'Success')]")]
        IWebElement _messageAuthenticationSuccessful;

        public SignIn(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }
   
        public void enterEmailAddress(String emailAddress)//*[@class="login"]
        {
            _emailAddress.Clear();
            _emailAddress.SendKeys(emailAddress);
        }

        public void clickCreateAccount()
        {
            _createAccount.Click();
        }

        public void enterRegisteredEmailAddress(String registeredEmailAddress)//*[@class="login"]
        {
            _registeredEmailAddress.Clear();
            _registeredEmailAddress.SendKeys(registeredEmailAddress);
        }


        public void enterPassword(String pwd)
        {
            _password.Clear();
            _password.SendKeys(pwd);
        }

        public void clickForgotYourPasswordLink()
        {

        }

        public void clickSignIn()
        {
            _signIn.Click();
        }

        public Boolean isAuthenticationFailedDisplayed()
        {
            try
            {
                return _errorMessageAuthenticationFailed.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }      
        }

        public void checkEmailAddress()
        {

        }

    }
}
