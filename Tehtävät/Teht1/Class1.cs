using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioKurssi
{
    class Class1
    {
        static void Main(string[] args)
        {
            OlioAuto auto = new OlioAuto();

            auto.nimi = "Toyota";

            auto.nopeus = 80;

            auto.renkaat = 4;

            auto.tulostadata();

            string autotiedot = auto.ToString();

            Console.WriteLine(autotiedot);

            Console.WriteLine();


            OlioAuto mopo = new OlioAuto();
            mopo.nimi = "Skootteri";
            mopo.nopeus = 80;
            mopo.renkaat = 2;

            mopo.tulostadata();
            Console.WriteLine(mopo.ToString());

            Console.ReadLine();
        }
    }
}