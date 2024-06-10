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

namespace Teht_21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> SelectedItems = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                SelectedItems.Add(radioButton.Content.ToString());
                ListView.Items.Add(radioButton.Content.ToString());
                // Lisää radiobuttonin Textin Listaan suoraan napin painalluksesta
            }
        }
    }
}
