using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    /// <summary>
    /// Object to hold over-arching information about the budget
    /// </summary>
    [Serializable]
    public class BudgetInformation
    {
        public ObservableCollection<Account> Accounts { get; set; } = new ObservableCollection<Account>();

        public ObservableCollection<Expense> Expenses { get; set; } = new ObservableCollection<Expense>();


        public bool IsEmpty()
        {
            return Accounts.Count == 0 && Expenses.Count == 0;
        }

    }
}
