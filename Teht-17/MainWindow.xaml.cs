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

namespace Teht_17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float lämpötila;
        private bool kettiönvalot;
        private bool olohuoneenvalot;
        private bool ovenlukko;
        public MainWindow()
        {
            InitializeComponent();
            SliderLämpö.Value = 40.0f;
        }
        private void SliderLämpö_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
            // Lämpotilan mittarin
        {
            float value = (float)SliderLämpö.Value;
            if (value < 0.0 || value > 35.00)
            {
                SliderLämpö.Value = Math.Max(35.00, Math.Min(0.00, value));
            }

            lämpötila = (float)SliderLämpö.Value;
            LbLämpö.Content = "Sisälämpötila: " + lämpötila.ToString() + "°C";
        }

        private void BtKeittiö_Click(object sender, RoutedEventArgs e)
            // Keittion valojen kytkin
        {
            if (kettiönvalot)
            {
                kettiönvalot = false;
                LbKeittiö.Content = "Keittiön valot: Kiinni";
            }
            else
            {
                kettiönvalot = true;
                LbKeittiö.Content = "Keittiön valot: Päällä";
            }
        }

        private void BtOlohuone_OnClick(object sender, RoutedEventArgs e)
            // Olohuoneen valojen kytkin
        {
            if (olohuoneenvalot)
            {
                olohuoneenvalot = false;
                Lbolohuone.Content = "Olohuoneen valot: Kiinni";
            }
            else
            {
                olohuoneenvalot = true;
                Lbolohuone.Content = "Olohuoneen valot: Päällä";
            }
        }

        private void BtOvi_OnClick(object sender, RoutedEventArgs e)
            // Oven lukon buttoni
        {
            if (ovenlukko)
            {
                ovenlukko = false;
                LbOvi.Content = "Oven lukko on: Kiinni";
            }
            else { ovenlukko = true; LbOvi.Content = "Oven lukko on: Auki"; }
        }
    }
}
