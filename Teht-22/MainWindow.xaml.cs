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

namespace Teht_22
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double Width = double.Parse(TbLeveys.Text);
            double Height = double.Parse(TbKorkeus.Text);
            double FrameWidth = double.Parse(TbLeveyss.Text);
            // width, height ja framewidt value = texti boxien output
            double GlassArea = Width * Height;
            double FrameArea = Width * FrameWidth;
            double TotalArea = GlassArea + FrameArea;

            ResultTextBlock.Text =
                $"Lasin pinta-ala: {GlassArea / 10000:.2f} m^2\n" +
                $"Ikkunan pinta-ala: {TotalArea / 10000:.2f} m^2\n" +
                $"Karmin piiri: {FrameWidth * 10} cm";
            // kaavat pinta-alan ja piirin laskemiseen
        }
    }
}
