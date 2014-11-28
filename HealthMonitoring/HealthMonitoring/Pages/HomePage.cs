using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace HealthMonitoring.Pages
{
    class HomePage : BasePage
    {
        public IWebDriver driver = BaseTest.GetWebDriver();

        private static HomePage page;

        public static HomePage GetHomePage()
        {
            if (page == null)
                page = new HomePage();
            return page;
        }


    }
}
