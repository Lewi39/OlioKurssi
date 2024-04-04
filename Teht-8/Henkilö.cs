using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_8
{
    class Henkilö
    {
        public virtual void Työpaikka()
        {
            Console.WriteLine("Amazon");
        }

        public virtual string Nimi { get; set; }
        public virtual void palkka()
        {
            Console.WriteLine("3700 e");
        }
        public virtual void TyöTunnit()
        {
            Console.WriteLine("40h");
        }


    }
    class työntekijä : Henkilö
    {
        public override void palkka()
        {
            base.palkka();
        }
        public override void Työpaikka()
        {
            base.Työpaikka();
        }
        public työntekijä(string nimi) : base()
        {
            Nimi = nimi;
        }
        public override void TyöTunnit()
        {
            base.TyöTunnit();
        }
    }
    class Pomo : Henkilö
    {
        public Pomo(string nimi) : base()
        {
            Nimi = nimi;
        }

        public override void palkka()
        {
            Console.WriteLine("4181 e");
        }
        public override void Työpaikka()
        {
            base.Työpaikka();
        }
    }
}
