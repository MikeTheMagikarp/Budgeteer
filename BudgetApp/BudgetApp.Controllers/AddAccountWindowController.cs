using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Controllers
{
    public class AddAccountWindowController
    {
        public void AddAccount(MainWindowController mainController, string name)
        {
            var account = new Account() { Name = name };
            mainController.Information.Accounts.Add(account);
        }
    }
}
