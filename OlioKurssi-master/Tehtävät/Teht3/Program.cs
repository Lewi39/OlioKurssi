    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas();

            kiuas.Merkki = "iki";

            kiuas.tulostadata();

            kiuas.MuutaLämpötilaa(80);

            kiuas.MuutaKosteutta(50);

            kiuas.KytkinPäälle();

            kiuas.tulostadata();

            kiuas.KytkinKiinni();

            kiuas.tulostadata();

            Console.ReadLine();

        }
    }
}
