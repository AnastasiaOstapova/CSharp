using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HealthMonitoring.Pages;

namespace HealthMonitoring.BusinessObjects
{
    class Logout
    {
        public void LogoutFromPage()
        {
            
            MenuBar.GetMenuBar().ClickOnLogoutDropdownMenu();
            MenuBar.GetMenuBar().ClickOnLogoutButton();
        }

    }
}
