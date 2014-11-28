using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace HealthMonitoring.Pages
{

    public abstract class BasePage
    {
        public IWebDriver driver = BaseTest.GetWebDriver();
        
        protected BasePage()
        {
            PageFactory.InitElements(driver, this);
            
        }


    }
}
