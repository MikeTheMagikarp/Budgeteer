using BudgetApp.Controllers;
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
    /// Interaction logic for AddAccountWindow.xaml
    /// </summary>
    public partial class AddAccountWindow : Window
    {
        public MainWindowController MainController;

        public AddAccountWindowController Controller = new AddAccountWindowController();

        public AddAccountWindow(MainWindowController mainController)
        {
            MainController = mainController;
            InitializeComponent();
        }

        private void AddAccountButton_Click(object sender, RoutedEventArgs e)
        {
            Controller.AddAccount(MainController, AccountNameTextBox.Text);
            this.Close();
        }
    }
}
