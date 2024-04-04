using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();

            while (true)
            {
                Console.WriteLine("");
                Console.Write("Anna uusi kerros (1-6): ");
                string userinput = Console.ReadLine();

                if (int.TryParse(userinput, out int KerrosInput))
                {
                    hissi.KerrosOutput(KerrosInput);
                }
            }
            
        }
        
    }
}
