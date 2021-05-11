using BudgetApp.Controllers;
using BudgetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BudgetApp
{
    /// <summary>
    /// Interaction logic for AddExpenseWindow.xaml
    /// </summary>
    public partial class AddExpenseWindow : Window
    {
        private MainWindowController _mainController;

        public AddExpenseWindowController Controller = new AddExpenseWindowController();

        public AddExpenseWindow(MainWindowController mainController)
        {
            _mainController = mainController;
            Controller.Accounts = mainController.Information.Accounts;

            DataContext = Controller;

            InitializeComponent();
        }

        private void AddExpenseButton_Click(object sender, RoutedEventArgs e)
        {
            Controller.AddExpense(_mainController, NameControl.LocalTextBox, ValueControl.LocalTextBox, AccountComboBox.SelectedItem as Account, DayOfPaymentControl.LocalTextBox, AccountTypeComboBox.SelectedItem);
            this.Close();
        }
    }
}
