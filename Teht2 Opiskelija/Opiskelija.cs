using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2 Opiskelija
{
    internal class Opiskelija
    {
        //Olion muuttujat
        private string nimi {  get; set; }
        private string OpiskelijaID { get; set; }
        private int OpintoPisteet { get; set; }


        // muuttujille lyhenteet, joita voi käyttää suuremmissa projekteissa
        public Opiskelija(string _Name, string _ID, int _OP)
        {
            this.nimi = _Name;
            OpiskelijaID = _ID;
            OpintoPisteet = _OP;
        }

        //etsitään olemassa olevan olion tiedot 
        public void tulostadata()

        {
            Console.WriteLine();
            Console.WriteLine("Opiskelija");
            Console.WriteLine("-- nimi " + nimi);
            Console.WriteLine("-- OpiskelijaID " + OpiskelijaID);
            Console.WriteLine("-- OpintoPisteet " + OpintoPisteet);
            Console.WriteLine();
        }

        public void MuokkaaOpintoPisteitä(int i )
        {
            OpintoPisteet += i;

            if ( OpintoPisteet > 0)
            {
                OpintoPisteet = 0;
            }
        }
    }
}
