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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BudgetApp
{
    /// <summary>
    /// Interaction logic for LabelTextBoxUserControl.xaml
    /// </summary>
    public partial class LabelTextBoxUserControl : UserControl
    {
        public LabelTextBoxUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string LocalLabel { get; set; }
        public string LocalTextBox { get; set; }

        public string Label
        {
            get { return LocalLabel; }
            set
            {
                LocalLabel = value;
                BaseLabel.Content = value;
            }
        }

        public string TextBox
        {
            get { return LocalTextBox; }
            set
            {
                LocalTextBox = value;
                BaseTextBox.Text = value;
            }
        }
    }
}
