using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace HealthMonitoring.Pages
{
    class AddNewUserPage : BasePage
    {
        public IWebDriver driver = BaseTest.GetWebDriver();

        private static AddNewUserPage page;
        
        public const string NAME_FIELD_FOR_NEW_USER = "userName";
        public const string EMAIL_FIELD_NEW_USER = "userEmail";
        public const string PASSWORD_FIELD_NEW_USER = "password";
        public const string CONFIRM_PASSWORD_FIELD_NEW_USER = "confirmpassword";
        public const string PHONE_FIELD_NEW_USER = "phone";
        public const string SAVE_NEW_USER_BUTTON = "//button[@class='ico ico-save']";

        [FindsBy(How = How.Name, Using = NAME_FIELD_FOR_NEW_USER)] 
        public IWebElement NameFieldForNewUser;

        [FindsBy(How = How.Name, Using = EMAIL_FIELD_NEW_USER)]
        public IWebElement EmailFieldForNewUser;

        [FindsBy(How = How.Name, Using = PASSWORD_FIELD_NEW_USER)]
        public IWebElement PasswordFieldForNewUser;

        [FindsBy(How = How.Name, Using = CONFIRM_PASSWORD_FIELD_NEW_USER)]
        public IWebElement ConfirmPasswordFieldForNewUser;

        [FindsBy(How = How.Name, Using = PHONE_FIELD_NEW_USER)]
        public IWebElement PhoneFieldForNewUser;

        [FindsBy(How = How.XPath, Using = SAVE_NEW_USER_BUTTON)]
        public IWebElement SaveNewUserButton;


        public static AddNewUserPage GetAddNewUserPage()
        {
            if (page == null)
                page = new AddNewUserPage();
            return page;
        }

        public void EnterUserName(string userName)
        {
            NameFieldForNewUser.Clear();
            NameFieldForNewUser.SendKeys(userName);
        }

        public void EnterUserEmail(string userEmail)
        {
            EmailFieldForNewUser.Clear();
            EmailFieldForNewUser.SendKeys(userEmail);
        }

        public void EnterUserPassword(string userPassword)
        {
            PasswordFieldForNewUser.Clear();
            PasswordFieldForNewUser.SendKeys(userPassword);
        }

        public void ConformUserPassword(string userPassword)
        {
            ConfirmPasswordFieldForNewUser.Clear();
            ConfirmPasswordFieldForNewUser.SendKeys(userPassword);
        }

        public void EnterUserPhoneNumber(string userPhoneNumber)
        {
            PhoneFieldForNewUser.Clear();
            PhoneFieldForNewUser.SendKeys(userPhoneNumber);
        }

        public void ClickOnSaveNewUserButton()
        {
            SaveNewUserButton.Click();
        }

    }
}
