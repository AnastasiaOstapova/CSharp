using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace HealthMonitoring.Pages
{
    class UsersListPage : BasePage
    {
        public static string userName = "test";
        
        public IWebDriver driver = BaseTest.GetWebDriver();

        private static UsersListPage page;
        
        

        public const string LOCATOR_ADD_NEW_USER_BUTTON = "//button[@class='ico ico-add']";
        public const string LOCATOR_DELETE_USER_BUTTON = "//button[@class='ico ico-delete']";
        public const string LOCATOR_NEW_USER_NAME = "//span[contains(@class, 'k-in') and contains(text(), 'TestUser')]";
        public const string LOCATOR_CONFIRM_DELETING_USER = "//button/span[contains(text(), 'Ok')]";

        [FindsBy(How = How.XPath, Using = LOCATOR_ADD_NEW_USER_BUTTON)] 
        public IWebElement AddNewUserButton;

        [FindsBy(How = How.XPath, Using = LOCATOR_DELETE_USER_BUTTON)]
        public IWebElement DeleteNewUserButton;

        [FindsBy(How = How.XPath, Using = LOCATOR_NEW_USER_NAME)]
        public IWebElement NewUserElement;

        [FindsBy(How = How.XPath, Using = LOCATOR_CONFIRM_DELETING_USER)]
        public IWebElement ConfirmDeletingUser;

        public static UsersListPage GetUsersListPage()
        {
            if (page == null)
                page = new UsersListPage();
            return page;
        }

        public void ClickOnAddNewUserButton()
        {
            AddNewUserButton.Click();
        }

        public void ClickOnDeleteUserButton()
        {
            DeleteNewUserButton.Click();
        }

        public void SelectNewUserToDelete()
        {
            NewUserElement.Click();
        }

        public void ConfirmDeleteUser()
        {
            ConfirmDeletingUser.Click();
        }
    }
}
