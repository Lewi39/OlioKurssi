using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioKurssi
{
    class OlioAuto
    {
        public string nimi { get; set; }
        public int nopeus { get; set; }
        public int renkaat { get; set; }


        public void tulostadata()
        {
            Console.WriteLine("Ajoneuvo: ");
            Console.WriteLine("-- nimi " + nimi);
            Console.WriteLine("-- nopeus " + nopeus);
            Console.WriteLine("-- Renkaat " + renkaat);
        }

        public string ToString()
        {
            string merkkijono = "Ajoneuvo nimi: " + nimi + " Nopeus: " + nopeus + "km/h. Renkaat: " + renkaat + "kpl";
            return merkkijono;
        }

    }
}