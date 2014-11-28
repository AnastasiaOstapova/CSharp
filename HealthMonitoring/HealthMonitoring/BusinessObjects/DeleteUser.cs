using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthMonitoring.Pages;

namespace HealthMonitoring.BusinessObjects
{
    class DeleteUser
    {
        public void DeleteNewUser()
        {
            MenuBar.GetMenuBar().ClickOnUsersListLabel();
            UsersListPage.GetUsersListPage().SelectNewUserToDelete();
            UsersListPage.GetUsersListPage().ClickOnDeleteUserButton();
            UsersListPage.GetUsersListPage().ConfirmDeleteUser();
            var logout = new Logout();
            logout.LogoutFromPage();
        }
    }
}
