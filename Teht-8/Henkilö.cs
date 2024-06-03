using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_8
{
    abstract class Henkilö
    {
        public virtual void Työpaikka()
        {
            Console.WriteLine("Amazon");
        }
        public abstract void PrintData();
        public virtual string Nimi { get; set; }        
        public virtual void palkka()
        {
            Console.WriteLine("3700 e");
        }      
        public float Bonus {  get; set; }
    }
    class työntekijä : Henkilö
    {
        public int TyöTunnit {  get; set; }
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

        public override void PrintData()
        {
            Console.WriteLine("Työntekijät");
            Console.WriteLine("Nimi: "+  Nimi);
            Console.Write("Työpaikka: ");
            Työpaikka();
            Console.WriteLine("Työaika" + TyöTunnit);
            palkka();
        }   //Methodi datan printtaukseen

    }
    class Pomo : Henkilö
    {
        public float bonus { get; set; }
        public string AutonMerkki { get; set; }
        public Pomo(string nimi) : base()
        {
            Nimi = nimi;
            bonus = 0.13f;
        }
        public override void palkka()
        {
            Console.WriteLine("4181 e");    
        }
        public override void Työpaikka()
        {
            base.Työpaikka();
        }

        public override void PrintData()
        {
            Console.WriteLine();
            Console.WriteLine("Esimiehet");
            Console.WriteLine("Nimi: " + Nimi);
            Console.Write("Työpaikka: ");
            Työpaikka();
            Console.WriteLine("Bonus: 1" + (Bonus * 100) + " %");
            palkka();
            Console.WriteLine("Autonmerkki: " + AutonMerkki);

        }
    }
}