using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht_10
{
    class Ahven : animal, I_Can_Swim
    {
        public int Swim_Speed { get; set; }

        public Ahven(String _Name, int _Swim_Speed)
        {
            Name = _Name;
            Swim_Speed = _Swim_Speed;
        }

        public void Swim()
        {
            Console.WriteLine("{0} Ui vedessä. Uinti nopeus on. {1} ", Name, Swim_Speed);
        }

        public override void Make_A_Sound()
        {
            Console.WriteLine("blub blub");
        }
    }
}
