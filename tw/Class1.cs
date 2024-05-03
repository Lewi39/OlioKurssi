using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tw
{
    class Korttipakka
    {

        public int i = 0;

        public int P = 1;

        public List<int> Maat = new List<int>();
        public List<Korttipakka> Pata = new List<Korttipakka>();
        public List<int> Risti = new List<int>();
        public List<int> Ruutu = new List<int>();
        public List<int> Hertta = new List<int>();

        public Korttipakka(int i, int p)
        {
            this.i = i;
            P = p;
        }

        public Korttipakka()
        {
        }

        public void Main()
        {
            //Pata korttien lisäys
            for (i = 1; i < 14; i++)
            {
                Pata.Add(new Korttipakka(i, P));
            }
            //Risti korttien lisäys      
            for (i = 1; i < 14; i++)

            {
                Risti.Add(i);
            }

            //Ruutu korttien lisäys

            for (i = 1; i < 14; i++)
            {
                Ruutu.Add(i);
            }

            //Hertta korttien lisäys

            for (i = 1; i < 14; i++)
            {
                Hertta.Add(i);
            }
            System.Collections.IList list = Pata;
            for (int i1 = 0; i1 < list.Count; i1++)
            {
                Console.WriteLine("Kortti on: Pata " + i);

                Console.WriteLine();
            }
            // ^Pata korttien output^

            foreach (int i in Risti)
            {
                Console.WriteLine("Kortti on: Risti " + i);

                Console.WriteLine();
            }
            // ^Risti korttien output^
            foreach (int i in Ruutu)
            {
                Console.WriteLine("Kortti on: Ruutu " + i);

                Console.WriteLine();
            }
            // ^Ruutu korttien output^
            foreach (int i in Hertta)
            {
                Console.WriteLine("Kortti on: Hertta " + i);
                Console.WriteLine();
            }
            // ^Hertta korttien output^


        }
    }
}
