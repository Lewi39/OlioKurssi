using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2 Opiskelija
{
    class Program
    {
        static void Main(string[] args)
        {
            // Annetaan data muuttujille, jotka on julkiseen "opiskelija" metodiin 

            Opiskelija opiskelija1 = new Opiskelija("Pete", "1", 0);

            Opiskelija opiskelija2 = new Opiskelija("Esa", "2", 20);

            Opiskelija opiskelija3 = new Opiskelija("Pena", "3", 22);

            Opiskelija opiskelija4 = new Opiskelija("Heikki", "4", 67);

            Opiskelija opiskelija5 = new Opiskelija("Matias", "5", 37);



            //printataan data konsoliin
            opiskelija1.tulostadata();
            opiskelija2.tulostadata();
            opiskelija3.tulostadata();
            opiskelija4.tulostadata();
            opiskelija5.tulostadata();

            
            Console.ReadLine();
        }
    }
}
