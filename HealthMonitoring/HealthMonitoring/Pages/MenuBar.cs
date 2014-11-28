using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;

namespace HealthMonitoring.Pages
{
    class MenuBar : BasePage
    {
        public IWebDriver driver = BaseTest.GetWebDriver();

        private static MenuBar page;

        public const string LOCATOR_FOR_USERS_LIST = "//a[contains(text(), 'USERS')]"; 
        public const string LOCATOR_FOR_LOGOUT_DROPDOWN_MENU = "//a[@id='user-name']";
        public const string LOCATOR_FOR_LOGOUT_BUTTON = "//div[@id='flyoutUser']/ul/li[2]/a";

        [FindsBy(How = How.XPath, Using = LOCATOR_FOR_USERS_LIST)]
        public IWebElement UsersListOnMenuBar;

        [FindsBy(How = How.XPath, Using = LOCATOR_FOR_LOGOUT_DROPDOWN_MENU)]
        public IWebElement LogoutDropdownElement;

        [FindsBy(How = How.XPath, Using = LOCATOR_FOR_LOGOUT_BUTTON)]
        public IWebElement LogoutButtonElement;

        public static MenuBar GetMenuBar()
        {
            if (page == null)
                page = new MenuBar();
            return page;
        }

        
        public void ClickOnUsersListLabel()
        {
            UsersListOnMenuBar.Click();
            
        }

        public void ClickOnLogoutDropdownMenu()
        {
            LogoutDropdownElement.Click();
        }

        public void ClickOnLogoutButton()
        {
            LogoutButtonElement.Click();
        }

        public string GetUserName()
        {
            return LogoutDropdownElement.Text;
        }
    }
}
