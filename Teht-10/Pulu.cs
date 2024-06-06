using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht_10
{
    class Pulu : animal, I_Can_Fly
    {
        public float Wing_Size { get; set; }
        public Pulu (string _Name, float _Wing_Size)
        {
                Name = _Name;
            Wing_Size = _Wing_Size;
        }
        public void fly()
        {
            Console.WriteLine("{0} Lentää ilmassa. Siipien koko on {1} ", Name, Wing_Size);
        }
        public override void Make_A_Sound()
        {
            Console.WriteLine(".-.");
        }
    }
}
