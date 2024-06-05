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

namespace Teht_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Cars = 0;
        private int Trucks = 0;
        public MainWindow()
        {
            InitializeComponent();
            TbCar.Text = Cars.ToString();
            TbTruck.Text = Trucks.ToString();
        }
        private void BtnCar_Click(object sender, RoutedEventArgs e)
        {
            Cars++;
            TbCar.Text = Cars.ToString();
            // Lisää arvon aina auton klikkauksesta ja muokkaa sen stringiksi josta text boxi lukee arvon
        }
        private void BtnTruck_Click(object sender, RoutedEventArgs e)
        {
            Trucks++;
            TbTruck.Text = Trucks.ToString();
            // Lisää arvon aina rekan klikkauksesta ja muokkaa sen stringiksi josta text boxi lukee arvon
        }
    }
}
