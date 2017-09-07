using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Dress_Pattern
{
    public class Problem_3___Dress_Pattern
    {
        public static void Main()
        {

            var n = int.Parse(Console.ReadLine());
            var width = 12 * n + 2;

            //first line
            Console.Write(new string ('_', n*4));
            Console.Write(".");
            Console.Write(new string('_', n * 4));
            Console.Write(".");
            Console.WriteLine(new string('_', n * 4));

            //sleeves
            var stars = 2;
            var dashes = (width - stars*2 - 4)/3;
            for (int i = 0; i < n*2; i++)
            {
                Console.Write(new string('_', dashes));
                Console.Write(".");
                Console.Write(new string('*', stars));
                Console.Write(".");
                Console.Write(new string('_', dashes));
                Console.Write(".");
                Console.Write(new string('*', stars));
                Console.Write(".");
                Console.WriteLine(new string('_', dashes));
                stars += 3;
                dashes -= 2;
            }

            //body
            for (int i = 0; i < n; i++)
            {
                Console.Write(".");
                Console.Write(new string('*', width-2));
                Console.WriteLine(".");
            }

            var dots = 3 * n;
            Console.Write(new string('.', dots));
            Console.Write(new string('*', width - 2*dots));
            Console.WriteLine(new string('.', dots));

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('_', dots));
                Console.Write(new string('o', width - 2*dots));
                Console.WriteLine(new string('_', dots));
            }


            //bottom

            for (int i = 0; i < n*3; i++)
            {
                Console.Write(new string('_', dots));
                Console.Write(".");
                Console.Write(new string('*', width - 2 * dots -2));
                Console.Write(".");
                Console.WriteLine(new string('_', dots));
                dots --;
            }

            //bottom line
            Console.WriteLine(new string('.', width));
        }
    }
}
