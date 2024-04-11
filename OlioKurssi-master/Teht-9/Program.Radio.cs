using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Teht_9;
using Teht_9.Teht_9;

class Program
{
    static void Main(string[] args)
    {
        Radio radio = new Radio();
        bool kytkinn = false;

        while (true)
        {
            if (!kytkinn)
            {
                Console.Write("Laita radio päälle (kyllä/ei): ");   //Kysyy laitetaanko radio päälle, jonka jälkeen annetaan arvot äänenkorkeudelle ja taajuudelle
                string userinput_kytkin = Console.ReadLine();
                if (userinput_kytkin.ToLower() == "kyllä")
                {
                    kytkinn = true;
                    radio.Kytkin_Päälle();
                }
                else if (userinput_kytkin.ToLower() == "ei")
                {
                    Console.WriteLine("Radio suljetaan.");
                    return;
                }
                else
                {
                    Console.WriteLine("Radio täytyy olla päällä ennen kuin voit säätää äänenvoimakkuutta tai taajuutta.");
                    continue;
                }
            }

            Console.WriteLine("");
            Console.Write("Äänenvoimakkuus: ");
            string userinput = Console.ReadLine();

            if (int.TryParse(userinput, out int Äänen_Voimakkuuss))
            {
                radio.Äänen_Voimakkuus = Äänen_Voimakkuuss;
            }
            else if (Äänen_Voimakkuuss <= 0)
            {
                Console.WriteLine("Äänenvoimakkuus on jo alimmalla tasolla");
            }
            else
            {
                Console.WriteLine("Äänenvoimakkuus on jo korkeimmalla tasolla");
            }

            Console.Write("Taajuus: ");
            string userinput_Taajuus = Console.ReadLine();
            if (float.TryParse(userinput_Taajuus, out float taajuus))
            {
                radio.Taajus_Valinta = taajuus;
            }
            if (taajuus == 100.0f)      // jos käyttäjän antama taajuus on yhtä suuri kuin suomipop kanavan silloin radio löytää kanavan suomipop
            {
                Suomipop suomipop_kanava = new Suomipop();
                Console.Write("Kanava on löydetty ");
                suomipop_kanava.Print_Kanava_Data();           
            } 
            if (taajuus == 89.0f)
            {
                SuomiRock suomi_Rock_Kanava = new SuomiRock();
                Console.Write("Kanava on löydetty ");
                suomi_Rock_Kanava.Print_Kanava_Data();
            }
        }
    }
}