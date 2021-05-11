using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    [Serializable]
    public class Account
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
