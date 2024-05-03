using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace t12
{
    class Korttipakka
    {
        public int i = 0;
        public int P = 1;

        public List<int> Maat = new List<int>();
        public List<int> Pata = new List<int>();
        public List<int> Risti = new List<int>();
        public List<int> Ruutu = new List<int>();
        public List<int> Hertta = new List<int>();
        public List<string> Test = new List<string>();

        public void Main()
        {
            //Pata korttien lisäys
            for (i = 1; i < 14; i++)
            {
                Pata.Add(i);
            }
            /*foreach (int i in Pata)
            {
                Console.WriteLine("Kortti on: Pata " + i);

                Console.WriteLine();

            }*/
            Maat.AddRange(Pata);
            // ^Pata korttien output^
            //---------------------------------------------------------------------------------------
            //Risti korttien lisäys
            for (i = 1; i < 14; i++)
            {
                Risti.Add(i);
            }
            /*foreach (int i in Risti)
            {
                Console.WriteLine("Kortti on: Risti " + i);

                Console.WriteLine();
            }*/
            Maat.AddRange(Risti);
            // ^Risti korttien output^
            //-----------------------------------------------------------------------------------------
            //Hertta korttien lisäys
            for (i = 1; i < 14; i++)
            {
                Hertta.Add(i);
            }
            /*foreach (int i in Hertta)
            {
                Console.WriteLine("Kortti on: Hertta " + i);
                Console.WriteLine();
            }*/
            Maat.AddRange(Hertta);
            // ^Hertta korttien output^
            //--------------------------------------------------------------------------------------------
            //Ruutu korttien lisäys
            for (i = 1; i < 14; i++)
            {
                Ruutu.Add(i);
            }
            /*foreach (int i in Ruutu)
            {
                Console.WriteLine("Kortti on: Ruutu " + i);

                Console.WriteLine();
            }*/
            Maat.AddRange(Ruutu);
            // ^Ruutu korttien output^
            //-------------------------------------------------------------------------------------------

            int Pata_Count = 0;
            int Risti_Count = 0;
            int Ruutu_Count = 0;
            int Hertta_Count = 0;

            foreach (int Kortti in Maat)
            {
                if (Pata_Count < 13)
                {

                    string Card_Data = "Kortti on Pata: - " + Kortti;
                    Console.WriteLine("");
                    Test.Add(Card_Data);
                    Pata_Count++;
                }

                else if (Risti_Count < 13)
                {
                    string Card_Data = "Kortti on Risti: - " + Kortti;
                    Console.WriteLine("");
                    Test.Add(Card_Data);
                    Risti_Count++;
                }
                else if (Ruutu_Count < 13)
                {
                    String Card_Data = "Kortti on Ruutu: - " + Kortti;
                    Console.WriteLine("");
                    Test.Add(Card_Data);
                    Ruutu_Count++;
                }
                else if (Hertta_Count < 13)
                {
                    String Card_Data = "Kortti on Hertta: - " + Kortti;
                    Console.WriteLine("");
                    Test.Add(Card_Data);
                    Hertta_Count++;
                }
            }
            foreach (string card in Test)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            Test = Test.OrderBy(i => Guid.NewGuid()).ToList();

            foreach (string card in Test)
            {
                Console.WriteLine(card);
            }
            // Ctrl + c 
            // Ctrl + v
            /*if (Pata_Count > 13)
                foreach (int i in Maat)
                {
                    Console.WriteLine("Kortti on Pata: " + i);
                    Pata_Count++;
                }
            else if (Risti_Count > 13)
            {
                foreach (int i in Maat)
                {
                    Console.WriteLine("Kortti on Risti " + i);
                    Risti_Count++;
                }
            }
            else if (Hertta_Count > 13)
            {
                foreach (int i in Maat)
                {
                    Console.WriteLine("Kortti on Hertta " + i);
                    Hertta_Count++;
                }
            }
            else if (Ruutu_Count > 13)
            {
                foreach (int i in Maat)
                {
                    Console.WriteLine("Kortti on Ruutu " + i);
                    Ruutu_Count++;
                }
            }*/
        }
    }
}
