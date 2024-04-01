using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Teht_7
{
    class Hissi
    {
        private int kerros;
        public int Kerros 
        {
            get { return kerros; }
            set
            {

                if (value >=1 && value <= 6)
                {
                    kerros = value;
                }
                else
                {
                    Console.WriteLine("Error: Virheellinen kerros");
                }
            }
        }
        public void KerrosOutput(int KerrosInput)
        {
            Kerros = KerrosInput;
            Console.WriteLine($"Hissi on nyt kerroksessa {kerros}.");
        }

    }
}
