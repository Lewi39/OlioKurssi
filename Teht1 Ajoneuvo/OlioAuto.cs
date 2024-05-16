using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioKurssi
{
    class Class1
    {
        static void Main()
        {
            OlioAuto auto = new OlioAuto();

            auto.Nimi = "Toyota";
            auto.Nopeus = 80;
            auto.Renkaat = 4;

            auto.tulostadata();


            string autotiedot = auto.ToString();

            Console.WriteLine(autotiedot);

            Console.WriteLine();


            OlioAuto mopo = new OlioAuto();
            mopo.Nimi = "Skootteri";
            mopo.Nopeus = 80;
            mopo.Renkaat = 2;

            mopo.tulostadata();
            Console.WriteLine(mopo.ToString());

            Console.ReadLine();
        }
    }
}