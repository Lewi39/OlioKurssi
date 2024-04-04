using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Henkilö OlioTyöntekijä = new työntekijä("Pena");

            Henkilö OlioPomo = new Pomo("Pete");

            Console.WriteLine("Työntekijät");
            Console.WriteLine("Nimi: " + OlioTyöntekijä.Nimi);
            OlioTyöntekijä.Työpaikka();
            OlioTyöntekijä.TyöTunnit();
            OlioTyöntekijä.palkka();


            Console.WriteLine(OlioPomo.Nimi);
            OlioPomo.palkka();
            OlioPomo.Työpaikka();

            Console.ReadLine();


        }
        
    }
}
