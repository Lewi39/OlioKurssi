using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t11
{
    internal class Program
    {
        public static void Main()
        {

            Dictionary<string, int> StudentId = new Dictionary<string, int>();
            StudentId.Add("Name1", 1);
            StudentId.Add("Name2", 2);
            StudentId.Add("Name3", 3);
            Console.WriteLine("Student num: = "+ StudentId["Name1"]);

            Console.ReadLine();
        }
    }
}
