using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_Remove_Negatives_and_Reverse
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var newList = input.Split(' ').Select(int.Parse).ToList();

            var finalList = new List<int>();

            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] >= 0)
                {
                    finalList.Add(newList[i]);
                }
            }

            if (finalList.Count > 0)
            {
                finalList.Reverse();
                Console.WriteLine(string.Join(" ", finalList));
            }
            else Console.WriteLine("empty");
            
        }
    }
}
