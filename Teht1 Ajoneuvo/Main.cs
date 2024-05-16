using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioKurssi
{
    class OlioAuto
    {
        public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }


        public void tulostadata()   
        {
            Console.WriteLine("Ajoneuvo: ");
            Console.WriteLine("-- nimi " + Nimi);
            Console.WriteLine("-- nopeus " + Nopeus);
            Console.WriteLine("-- Renkaat " + Renkaat);
        }   //Methodi datan tulostukseen

        public override string ToString()
        {
            string merkkijono = "Ajoneuvo nimi: " + Nimi + " Nopeus: " + Nopeus + "km/h. Renkaat: " + Renkaat + "kpl";
            return merkkijono;
        }

    }
}