using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuas
{
    internal class Kiuas
    {
        //Muuttujat
        public string Merkki {  get; set; }
        public int Lämpötila { get; set; }
        public int kosteus { get; set; }
        public bool Kytkin { get; set; }

        //Tulostaa Muuttujien datan metodiin "tulostadata"
        public void tulostadata()
        {
            Console.WriteLine();
            Console.WriteLine("Kiuakaan merkki on: " + Merkki);
            Console.WriteLine("Lämpötila on: " + Lämpötila + "C");
            Console.WriteLine("Kosteus on: " + kosteus + "%");
            Console.WriteLine("Kytkin on: " + Kytkin);
            Console.WriteLine();

        }
        // Muuttaa Lämpötilaa
        public void MuutaLämpötilaa(int i)
        {
            Lämpötila += i;
            Console.WriteLine("Kiukaanlämpötila on muutettu: " + Lämpötila + "C");


        }
        //Muuttaa kosteutta 
        public void MuutaKosteutta(int i)
        {
            Console.WriteLine("Kosteutta on muutettu" + kosteus + "%");
        }
        //Muutta kytkimen tilaa
        public void KytkinPäälle()
        {
            Kytkin = true;
            Console.WriteLine("Kytkin on nyt päällä");
        }
        //Muutta kytkimen tilaa
        public void KytkinKiinni()
        {
            Kytkin = false;
            Console.WriteLine("Kytkin on nyt pois päältä");
        }
        
    }
}
