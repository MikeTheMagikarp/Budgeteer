using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Models
{
    [Serializable]
    public class Expense : INotifyPropertyChanged
    {
        
        #region Publics

        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        public double Value
        {
            get => _value;
            set => SetField(ref _value, value);
        }

        public Account Account
        {
            get => _account;
            set => SetField(ref _account, value);
        }

        public int DayOfPayment
        {
            get => _dayOfPayment;
            set => SetField(ref _dayOfPayment, value);
        }

        public AccountType Type
        {
            get => _type;
            set => SetField(ref _type, value);
        }

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #region Privates
        private string _name;
        
        private double _value;

        private Account _account;

        private int _dayOfPayment;

        private AccountType _type;

        #endregion
    }
}
