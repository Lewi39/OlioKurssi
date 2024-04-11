using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eläimet OlioKoira = new koira("Pena");
            Eläimet OlioPossu = new Possu("Pete");

            OlioKoira.EläintenÄäntely();
            OlioPossu.EläintenÄäntely();



            Console.WriteLine($"Eläimiä yhteensä: {Eläimet.AnimalAmount()}");

            Console.ReadLine();
        }
    }
}
