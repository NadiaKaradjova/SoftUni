using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_Change_List
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                var command = Console.ReadLine().Split(' ').ToList();

                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    DeleteNum(element, nums);
                    
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    InsertNum(position, element, nums);
                

                }
                else if (command[0] == "Odd")
                {
                    OddNum(nums);
                    break;
                }
                else if (command[0] == "Even")
                {
                    EvenNum(nums);
                    break;
                }

            }
            
        }


        public static List<int> DeleteNum(int element, List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
               nums.Remove(element);                             
            }           
            return nums;
        }

        public static List<int> InsertNum(int position, int element, List<int> nums)
        {
            nums.Insert(position, element);
            return nums;
        }

        public static void OddNum(List<int> nums)
        {
            var oddNumbers = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                var element = nums[i];
                if (element%2 != 0)
                {
                    oddNumbers.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", oddNumbers));

        }

        public static void EvenNum(List<int> nums)
        {
            var evenNumbers = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                var element = nums[i];
                if (element % 2 == 0)
                {
                    evenNumbers.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", evenNumbers));
            
        }
    }
   
}
