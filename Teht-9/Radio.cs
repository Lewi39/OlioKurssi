using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_9
{
    using System;

    namespace Teht_9
    {
        class Suomipop : Kanavat    //uusi ali-luokka kanavat luokkaan
        {
            public override float Taajuus()     // taajuus annettu uudessa luokassa 
            {
                return 100.0f;
            }

            public override void RadioKanavanNimi()     //kanavan nimi
            {
                Console.WriteLine("Suomipop");
            }
            // ylempi varmaa turhaan tossa, mutta se toimii nii antaa olla 
            public override void Print_Kanava_Data()    //printtaa radiokanavan nimen
            {
                Console.WriteLine("SuomiPop");
            }
        }

        class SuomiRock : Kanavat   //uusi ali-luokka kanavt luokkaan 
        {
            public override float Taajuus()     //taajuus luokalle
            {
                return 89.0f;
            }

            public override void RadioKanavanNimi() //kanavan nimi
            {
                Console.WriteLine("SuomiRock");
            }

            public override void Print_Kanava_Data()    //printtaa kanavan nimen
            {
                Console.WriteLine("SuomiRock");
            }
        }
        abstract class Kanavat      // uusi luokka 
        {
            public abstract void Print_Kanava_Data();

            public virtual float Taajuus()  //virtualiinen floatti taajuus 
            {
                return 1.5f;
            }

            public virtual void RadioKanavanNimi()
            {
                Console.WriteLine("");
            }
        }
        public class Radio  //radio luokka mikä  sisältää radion toimintoja 
        {
            public bool Kytkin { get; set; }    

            // Äänenvoimakkuuden muuttuja
            private int Ääneen_VoimakkuuSS;
            public virtual int Äänen_Voimakkuus
            {
                get { return Ääneen_VoimakkuuSS; }
                set
                {
                    if (value >= 1 && value <= 9)       //rajaa äänenvoimakkuuden korkeutta
                    {
                        Ääneen_VoimakkuuSS = value;
                        Console.WriteLine("Äänenvoimakkuus on nyt " + Ääneen_VoimakkuuSS);
                    }
                    else if (value <= 0)
                    {
                        Console.WriteLine("Äänenvoimakkuus on jo alimmalla tasolla");
                    }
                    else
                    {
                        Console.WriteLine("Äänenvoimakkuus on jo korkeimmalla tasolla");
                    }
                }
            }
            //Muutta kytkimen tilaa
            public void Kytkin_Päälle()
            {
                Kytkin = true;
                Console.WriteLine("Radio on nyt päällä");
            }
            public void Kytkin_Kiinni()
            {
                Kytkin = false;
                Console.WriteLine("Radio on nyt pois päältä");
            }
            //Taajuudenvalinta muuttuja
            private float Taajuss;
            public virtual float Taajus_Valinta
            {
                get { return Taajuss; }
                set
                {
                    if (value >= 88.0 && value <= 107.9)    //Rajoittaa taajuuden valintaa 
                    {
                        Taajuss = value;
                        Console.WriteLine("Taajuus löydetty " + Taajuss + "Hz");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Ei taajuutta");
                    }
                }
            }
        }







    }   
}
