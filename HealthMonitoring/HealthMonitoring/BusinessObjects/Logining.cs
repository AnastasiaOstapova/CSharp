using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthMonitoring.Pages;

namespace HealthMonitoring.BusinessObjects
{
    class Logining
    {
        public void DoLogining(string login, string password)
        {
            LoginPage.GetLoginPage().Open();
            LoginPage.GetLoginPage().TypeLoginName(login);
            LoginPage.GetLoginPage().TypePassword(password);
            LoginPage.GetLoginPage().ClickLoginButton();
        }
    }
}
