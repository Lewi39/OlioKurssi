using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht6
{
    class Eläimet
    {
        protected static int EläintenMäärä = 0;

        public Eläimet()
        {
            EläintenMäärä++;
        }

        public virtual void EläintenÄäntely()
        {
            Console.WriteLine("Eläintenääntelyä");
        }

        public virtual string Nimi {  get; set; }

        public static int AnimalAmount()
        {
            return EläintenMäärä;
        }
    }
        class Possu : Eläimet 
        {
        public override void EläintenÄäntely()
            {
            Console.WriteLine("Possu:   Oink oink");
            }

        public Possu(string nimi) : base()
        {
            Nimi = nimi;
        }

    }

        class koira : Eläimet
    {
        public override void EläintenÄäntely()
        {
            Console.WriteLine("Koira:   Wuf wuf");
        }

        public koira(string nimi) : base()
        {
            Nimi = nimi;
        }
    }
  
    
        
    




}
