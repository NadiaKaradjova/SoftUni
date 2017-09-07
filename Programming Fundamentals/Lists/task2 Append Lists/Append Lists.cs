using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_Append_Lists
{
    class Program
    {
        public static void Main()
        {
            var items = Console.ReadLine().Split('|').ToList();
            
            items.Reverse();

            var result = new List<string>();

            foreach (var item in items)
            {
                var nums = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(nums);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
