using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Strawberry
{
    public class _03_Strawberry
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            //top
            var dash = 0;
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('-', dash));
                Console.Write("\\");
                Console.Write(new string('-', n-dash));
                Console.Write("|");
                Console.Write(new string('-', n-dash));
                Console.Write("/");
                Console.WriteLine(new string('-', dash));
                dash += 2;
            }

            //middle
            dash = n;
            var dot = 1;
            for (int i = 0; i < n / 2 + 2; i++)
            {
                if (dash < 1)
                {
                    dash = 0;
                    dot = (n*2+3) - 2;
                }
                Console.Write(new string('-', dash));
                Console.Write("#");
                Console.Write(new string('.', dot));
                Console.Write("#");                           
                Console.WriteLine(new string('-', dash));
                dash -= 2;
                dot += 4;
            }

            //bottom
            dash = 1;
            dot = (2*n+3) - 4;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', dash));
                Console.Write("#");
                Console.Write(new string('.', dot));
                Console.Write("#");
                Console.WriteLine(new string('-', dash));
                dash += 1;
                dot -= 2;
            }

        }
    }
}
