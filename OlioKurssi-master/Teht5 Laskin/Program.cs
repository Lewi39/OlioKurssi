using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5_Laskin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 5.0f;
            float b = 2.5f;
            //arvot a:elle ja b:elle
            //kutsutaan laskimesta muuttujat laskemaan laskun
            float summa = Laskin.Summa(a, b);
            float erotus = Laskin.Erotus(a, b);
            float kertolasku = Laskin.Kertolasku(a, b);
            float jakolasku = Laskin.Jakolasku(a, b);

            //Printtaa laskut konsoliin näkyville
            Console.WriteLine("Numeroiden {0} ja {1}:", a, b);
            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Erotus: " + erotus);
            Console.WriteLine("Kertolasku: " + kertolasku);
            Console.WriteLine("Jakolasku: " +  jakolasku);

            
            Console.ReadLine();
        }
    }
}
