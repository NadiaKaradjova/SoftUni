using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var countedNumbers = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (!countedNumbers.ContainsKey(item))
                {
                    countedNumbers[item] = 0;
                }

                countedNumbers[item]++;
            }
            
            foreach (var item in countedNumbers)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}"); 
                }
        }
    }
}
