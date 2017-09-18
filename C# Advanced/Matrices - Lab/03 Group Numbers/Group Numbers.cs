using System;
using System.Linq;

namespace _03_Group_Numbers
{
    public class _03_Group_Numbers
    {
        public static void Main()
        {

            var numbers = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); 
            
            var jaggetArray = new int[3][];

            var zeroReminder = numbers.Where(x => Math.Abs(x % 3) == 0).ToArray();
            var oneReminder = numbers.Where(x => Math.Abs(x % 3) == 1).ToArray();
            var twoReminder = numbers.Where(x => Math.Abs(x % 3) == 2 ).ToArray();

            jaggetArray[0] = zeroReminder;
            jaggetArray[1] = oneReminder;
            jaggetArray[2] = twoReminder;

            foreach (var row in jaggetArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
