using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthMonitoring.Pages;

namespace HealthMonitoring.BusinessObjects
{
    class AddindNewUser
    {
        public void AddNewUser(string userName, string userEmail, string userPassword, string userPhone)
        {
            MenuBar.GetMenuBar().ClickOnUsersListLabel();
            UsersListPage.GetUsersListPage().ClickOnAddNewUserButton();
            AddNewUserPage.GetAddNewUserPage().EnterUserName(userName);
            AddNewUserPage.GetAddNewUserPage().EnterUserEmail(userEmail);
            AddNewUserPage.GetAddNewUserPage().EnterUserPassword(userPassword);
            AddNewUserPage.GetAddNewUserPage().ConformUserPassword(userPassword);
            AddNewUserPage.GetAddNewUserPage().ClickOnSaveNewUserButton();
            var logout = new Logout();
            logout.LogoutFromPage();
        }
    }
}
