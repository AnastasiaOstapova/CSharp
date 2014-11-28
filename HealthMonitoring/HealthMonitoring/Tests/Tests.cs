using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HealthMonitoring.BusinessObjects;
using HealthMonitoring.Pages;
using HealthMonitoring.TestData;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace HealthMonitoring
{
    [TestFixture]
    public class Tests : BaseTest
    {
        [Test]
        public void Test()
        {
            var logining = new Logining();
            logining.DoLogining(InputTestData.Login, InputTestData.Password);
            var addNewUser = new AddindNewUser();
            addNewUser.AddNewUser(InputTestData.NewUserName, InputTestData.NewUserEmail, InputTestData.NewUserPassword, InputTestData.NewUserPhone);
            logining.DoLogining(InputTestData.NewUserEmail, InputTestData.NewUserPassword);
            Assert.AreEqual(MenuBar.GetMenuBar().GetUserName(), InputTestData.NewUserName);
            var logout2 = new Logout();
            logout2.LogoutFromPage();
            var loginingAdm = new Logining();
            loginingAdm.DoLogining(InputTestData.Login, InputTestData.Password);
            var deleteUser = new DeleteUser();
            deleteUser.DeleteNewUser();
        }




    }
}
