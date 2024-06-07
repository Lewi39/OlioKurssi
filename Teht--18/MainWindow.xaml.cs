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

namespace Teht__18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;  // ensinmäinen numero inputti
        int second; // toinen numero inputti

        char op; // Operation
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtNum_Click(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            // Lyhenne "button"ille
            TbInput.Text += bt.Content.ToString();
            second = Int32.Parse(TbInput.Text);
        }
        private void BtDot_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TbInput.Text);
            op = '.';
        }
        private void BtSlash_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TbInput.Text);
            op = '/';
            // Operation == /
            TbInput.Clear();
            // Kun operationia ollaan painettu clearaantuu Input boxi

        }
        private void BtTimes_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TbInput.Text);
            op = '*';
            // Operation == *
            TbInput.Clear();
            // Kun operationia ollaan painettu clearaantuu Input boxi

        }
        private void BtPlus_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TbInput.Text);
            op = '+';
            // Operation == +

            TbInput.Clear();
            // Kun operationia ollaan painettu clearaantuu Input boxi

        }
        private void BtMinus_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TbInput.Text);
            op = '-';
            TbInput.Clear();
            // Kun operationia ollaan painettu clearaantuu Input boxi

        }
        private void btEquals_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(TbInput.Text);
            second = Int32.Parse(TbInput.Text);
            int Output = 0;


            // Jos yhtäsuuri nappia on painettu lasketaan sen tulos ensinmäisen numeron ennen laskutoimituksen
            // inputtia ja sen jälkeinen numero laskutoimituksen mukaan
            if (op == '+')
            {
                Output = first + second;
            }
            if (op == '-')
            {
                Output = second - first;
            }
            else if (op == '*')
            {
                Output = first * second;
            }
            else if (op == '/')
            {
                Output = first / second;
            }
            if (TbInput.Text == "0" && TbInput.Text != "")
            {
                TbInput.Clear();

            }
            TbInput.Text = Output.ToString();
        }
        private void BtClearAll_Click(object sender, RoutedEventArgs e)
        {
            TbInput.Text = "";
            // Clearaa output laatikon
        }
        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            string currentText = TbInput.Text;
            if (currentText.Length > 0)
            {
                TbInput.Text = currentText.Substring(0, currentText.Length - 1);
            }
        }
    }
}
