using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace HealthMonitoring
{
    public abstract class BaseTest
    {
        public static IWebDriver driver;

        public static IWebDriver GetWebDriver()
        {
            return driver;
        }
        
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public void TeatDown()
        {
            driver.Quit();
        }
    }
}
