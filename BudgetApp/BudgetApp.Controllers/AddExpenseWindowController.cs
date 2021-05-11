using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Controllers
{
    public class AddExpenseWindowController
    {
        public ObservableCollection<Account> Accounts { get; set; } = new ObservableCollection<Account>();

        public void AddExpense(MainWindowController mainController, string name, string value, Account account, string dayOfPayment, object AccountType)
        {
            var expense = new Expense()
            {
                Name = name,
                Value = double.Parse(value, CultureInfo.InvariantCulture),
                Account = account,
                DayOfPayment = int.Parse(dayOfPayment, CultureInfo.InvariantCulture),
            };

            mainController.Information.Expenses.Add(expense);
        }
    }
}
