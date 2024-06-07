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

namespace Teht_19
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SLKerros_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PBKerros.Value = (int)SLKerros.Value;
            // Progressbaarin arvo = SliderKerroksen arvo
        }
        private void PBKerros_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            PBKerros.Value = (int)SLKerros.Value;
            //Progressbaarin arvo = SliderKerroksen arvo
            TbOutput.Text = $"Kerros {Math.Floor(SLKerros.Value)}";
        }
    }
}
