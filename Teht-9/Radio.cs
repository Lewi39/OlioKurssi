using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_9
{
    abstract class Kanavat
    {
        public abstract void PrintKanavaData();
        
        public virtual float Taajuus()
        {
            return 1.5f;
        }

        public virtual void RadioKanavanNimi()
        {
            Console.WriteLine("");
        }
    }
    class Suomipop : Kanavat
    {
        public override float Taajuus()
        {
            return 100.0f;
        }

        public override void RadioKanavanNimi()
        {
            Console.WriteLine("SuomiPop");
        }

        public override void PrintKanavaData()
        {
            Console.WriteLine("Tulosta kanavan data");
        }
    }
    public class Radio
    {

        public bool Kytkin {  get; set; }

        // Äänenvoimakkuuden muuttuja
        private int ÄäneenVoimakkuuSS;
        public virtual int ÄänenVoimakkuus
        {
            get { return ÄäneenVoimakkuuSS; }
            set
            {
                if (value >= 1 && value <= 9)
                {
                    ÄäneenVoimakkuuSS = value;
                    Console.WriteLine("Äänenvoimakkuus on nyt " + ÄäneenVoimakkuuSS);
                }
                else if (value <=0)
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
        public void KytkinPäälle()
        {
            Kytkin = true;
            Console.WriteLine("Kytkin on nyt päällä");
        }
        public void KytkinKiinni()
        {
            Kytkin = false;
            Console.WriteLine("Kytkin on nyt pois päältä");
        }


        //Taajuudenvalinta muuttuja
        private float Taajuss;
        public virtual float TaajusValinta
        {
            get { return Taajuss; }
            set
            {
                if (value >= 88.0 && value <= 107.9)
                {
                    Taajuss = value;
                    Console.WriteLine("Taajuus löydetty " + Taajuss + "Hz");
                }
                else
                {
                    Console.WriteLine("Ei taajuutta");
                }
            }
        }
    }

    





}
