using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthMonitoring.TestData;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace HealthMonitoring.Pages
{
    class LoginPage : BasePage
    {
        public IWebDriver driver = BaseTest.GetWebDriver();

        private static LoginPage page;
        
        public const string SELECTOR_FOR_LOGIN_FIELD = "Email";
        public const string SELECTOR_FOR_PASSWORD_FIELD = "Password";
        public const string SELECTOR_FOR_LOGIN_BUTTON = "//input[@class='btn btn-default']";  
        
        [FindsBy(How = How.Id, Using = SELECTOR_FOR_LOGIN_FIELD)] 
        public IWebElement LoginField;

        [FindsBy(How = How.Id, Using = SELECTOR_FOR_PASSWORD_FIELD)]
        public IWebElement PasswordField;

        [FindsBy(How = How.XPath, Using = SELECTOR_FOR_LOGIN_BUTTON)]
        public IWebElement LoginButton;



        public static LoginPage GetLoginPage()
        {
            if (page == null)
                page = new LoginPage();
            return page;
        }

        public void Open()
        {
            driver.Navigate().GoToUrl(InputTestData.URL);
        }

        public void TypeLoginName(string loginName)
        {
            LoginField.Clear();
            LoginField.SendKeys(loginName);
        }

        public void TypePassword(string password)
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
           
        }

    }
}
