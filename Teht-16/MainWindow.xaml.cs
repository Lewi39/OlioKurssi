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

namespace Teht_16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void Bt_Km_To_Miles_Click(object sender, RoutedEventArgs e)
        {
            double Distance, Converteddis;
            Distance = double.Parse(TbEnter.Text);
            Converteddis = Distance * 0.621371;     //kilometreistä mileihin lasku kaava
            TbConvert.Text = Convert.ToString(Converteddis);
        }

        private void Bt_Miles_To_Km_Click(object sender, RoutedEventArgs e)
        {
            double Distance, Converteddis;
            Distance = double.Parse(TbEnter.Text);
            Converteddis = Distance * 1.609343502101154;    // Mileista kilometreihin lasku kaava
            TbConvert.Text = Convert.ToString(Converteddis);
        }

        private void BtClear_Click(object sender, RoutedEventArgs e)
        {
            TbEnter.Text = "";
            TbConvert.Text = "";
            TbEnter.Focus();    
            //tyhjentää teksi kentät
        }
    }
}
