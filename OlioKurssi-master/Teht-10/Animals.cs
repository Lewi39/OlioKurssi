using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Teht_10
{
    internal class Animals
    {
        public class animal
        {

            public interface ICanFly
            {
                void WingSize();

                void Fly();
            }

            public interface ICanSwim
            {
                void Speed();

                void Swim();
            }
            public class Lintu : ICanFly
            {
                public void WingSize()
                {
                    WingSize();
                }

                public void Fly()
                {
                    Fly();
                }
            }

            public class Pulu : Lintu
            {
             public override Animal.IcanFly   
            }

        }
    }
}
