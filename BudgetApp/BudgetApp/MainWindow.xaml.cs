using BudgetApp.Controllers;
using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BudgetApp.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowController Controller = new MainWindowController();

        public MainWindow()
        {
            DataContext = Controller;

            InitializeComponent();

        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            Controller.Load();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Controller.Save();
        }

        private void AddAccountButton_Click(object sender, RoutedEventArgs e)
        {
            AddAccountWindow p = new AddAccountWindow(Controller);

            p.Show();
        }

        private void AddExpenseButton_Click(object sender, RoutedEventArgs e)
        {
            AddExpenseWindow p = new AddExpenseWindow(Controller);

            p.Show();
        }
    }
}
