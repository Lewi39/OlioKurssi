using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace t12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Korttipakka My_Korttipakka = new Korttipakka();
            My_Korttipakka.Main();
            Console.ReadKey();         
        }        
    }
}
