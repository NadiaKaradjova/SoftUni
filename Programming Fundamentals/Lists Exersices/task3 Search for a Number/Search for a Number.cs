using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_Search_for_a_Number
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var manipulators = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var elementsToTake = manipulators[0];
            var elementsToDelete = manipulators[1];
            var numberToSearch = manipulators[2];

            nums.RemoveRange(elementsToTake, nums.Count-elementsToTake);
            nums.RemoveRange(0, elementsToDelete);

            if (nums.Contains(numberToSearch))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }            
        }
    }
}
