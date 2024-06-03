using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Teht_8
{
    internal class Program
    {
        static void Main()
        {
            Henkilö OlioTyöntekijä = new työntekijä("Pena");
            Henkilö OlioPomo = new Pomo("Pete");
            OlioTyöntekijä.PrintData();
            OlioPomo.PrintData();
            Console.ReadLine();
        }
    }
}

