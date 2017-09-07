using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower().Split(' ').ToList();
            
            var count = new Dictionary<string, int>();

            foreach (var item in text)
            {
                if (!count.ContainsKey(item))
                {
                    count[item] = 0;
                }
               count[item]++;
                
            }

            var oddFinal = new List<string>();

            foreach (var item in count)
            {
                if ((item.Value) % 2 != 0)
                {
                    oddFinal.Add(item.Key);                    
                }                
            }

            Console.WriteLine(string.Join(", ", oddFinal));
        }
    }
}
