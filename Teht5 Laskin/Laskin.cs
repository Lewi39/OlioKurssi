using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5_Laskin
{
    static class Laskin
    {
        // Muuttujat perus laskuihin, joita Program.cs voi kutsua käyttämään
        public static float Summa(float a, float b)
        {
            return a + b;
        }
        public static float Erotus (float a, float b)
        {
            return a - b;
        }
        public static float Kertolasku(float a, float b)
        {
            return a * b;
        }
        public static float Jakolasku(float a, float b)
        {
            return a / b;
        }
    }
}
