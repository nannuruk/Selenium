using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Demo1.Pages
{
    class ContactUs
    {
        [FindsBy(How = How.Id, Using = "id_contact")]
        IWebElement subHeading;

        [FindsBy(How = How.CssSelector, Using = "input[data-validate=isEmail]")]
        IWebElement contactEmailAddress;

        [FindsBy(How = How.XPath, Using = "//input[@id='id_order']")]
        IWebElement ordReference;

        [FindsBy(How = How.ClassName, Using = "input[form-control]")]
        IWebElement attachFile;

        [FindsBy(How = How.Id, Using = "message")]
        IWebElement Message;


        IWebElement Submit;
        
        public void chooseSubHeading()
        {

        }

        public void enterContactEmailAddress()
        {

        }

        public void enterOrdReference()
        {

        }

        public void clickChooseFile()
        {

        }

        public void enterMessage()
        {

        }

        public void clickSubmit()
        {

        }

    }
}
