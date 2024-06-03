using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pulu Pulu = new Pulu("Pulu", 50);
            Ahven ahven = new Ahven("Ahven", 40);
            Pulu.Make_A_Sound();
            Pulu.fly();
            ahven.Make_A_Sound();
            ahven.Swim();
            Console.ReadLine();
        }
    }
}
