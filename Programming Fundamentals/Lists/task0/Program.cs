using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                listOfNumbers.Add(i);
            }

            for (int i = 0; i < 10; i++)
            {
                listOfNumbers.RemoveAll(i%2=0);
            }
            
            Console.WriteLine(listOfNumbers.Count());
                       
            Console.WriteLine(string.Join(" ", listOfNumbers));
            
        }
    }
}
