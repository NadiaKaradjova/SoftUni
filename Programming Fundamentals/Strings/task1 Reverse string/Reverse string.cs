using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_Reverse_string
{
    public class task1_Reverse_string
    {
        public static void Main()
        {
            string n = Console.ReadLine();
            var b = n.Reverse();
            string c=null;

            foreach (var item in b)
            {
                c += item;
            }
            Console.WriteLine(c);
        }
    }
}
