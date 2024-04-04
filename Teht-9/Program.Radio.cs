using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Teht_9;

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
                Console.Write("Laita radio päälle (kyllä/ei): ");
                string vastaus = Console.ReadLine();
                if (vastaus.ToLower() == "kyllä")
                {
                    kytkinn = true;
                    radio.KytkinPäälle();
                }
                else if (vastaus.ToLower() == "ei")
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

            if (int.TryParse(userinput, out int ÄänenVoimakkuuss))
            {
                radio.ÄänenVoimakkuus = ÄänenVoimakkuuss;
            }
            else if (ÄänenVoimakkuuss <= 0)
            {
                Console.WriteLine("Äänenvoimakkuus on jo alimmalla tasolla");
            }
            else
            {
                Console.WriteLine("Äänenvoimakkuus on jo korkeimmalla tasolla");
            }

            Console.Write("Taajuus: ");
            string userinputTaajuus = Console.ReadLine();
            if (float.TryParse(userinputTaajuus, out float taajuus))
            {
                radio.TaajusValinta = taajuus;
            }
        }
    }
}