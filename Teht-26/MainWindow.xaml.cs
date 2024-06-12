using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Teht_26
{
    public partial class MainWindow : Window
    {
        //Yksikköjen muunnos kertoimet
        private static readonly Dictionary<string, double> Yksikkömuunnoskertoimet = new Dictionary<string, double>
{
    {"Kilometers", 1},
    {"Meters", 0.001},
    {"Centimeters", 0.00001},
    {"Yards", 0.0009144},
    {"Foot", 0.0003048},
    {"Inches", 0.0000254},
    {"Miles", 1.60934}
};
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Tarkistaa onko syötetty arvo numero
            if (double.TryParse(TbEnter.Text, out double AnnettuMatka))
            {
                string SelectedUnit1 = (CbInput.SelectedItem as ComboBoxItem)?.Content.ToString();
                string SelectedUnit2 = (CbOutput.SelectedItem as ComboBoxItem)?.Content.ToString();

                //tarkistaa jos yksikkömuunnokset löytyvät dictionarystä
                if (Yksikkömuunnoskertoimet.ContainsKey(SelectedUnit1) && Yksikkömuunnoskertoimet.ContainsKey(SelectedUnit2))
                {
                    // Laskee  muunnoskertoimen ja muunnetun arvon
                    double Muunnoskerroin = Yksikkömuunnoskertoimet[SelectedUnit1] / Yksikkömuunnoskertoimet[SelectedUnit2];
                    double Muunnettuarvo = AnnettuMatka * Muunnoskerroin;
                    TbConvertedOutput.Text = Muunnettuarvo.ToString();

                }
            }
        }
        private void BtClear_Click(object sender, RoutedEventArgs e)
        {
            TbEnter.Text = "";
            TbConvertedOutput.Text = "";
            TbEnter.Focus();
            //tyhjentää teksi kentät
        }
    }

}
