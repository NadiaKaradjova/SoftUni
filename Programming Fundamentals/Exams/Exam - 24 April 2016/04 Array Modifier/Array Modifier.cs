using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Array_Modifier
{
    public class _04_Array_Modifier
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var line = input.Split().ToArray();
                var command = line[0];

                if(command == "swap")
                {
                    var firstIndex = int.Parse(line[1]);
                    var secondIndex = int.Parse(line[2]);
                    Swap(numbers, firstIndex, secondIndex);
                }

                if (command == "multiply")
                {
                    var firstIndex = int.Parse(line[1]);
                    var secondIndex = int.Parse(line[2]);
                    Multiply(numbers, firstIndex, secondIndex);
                }

                if (command == "decrease")
                {
                    Decrease(numbers);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void Decrease(long[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] -= 1;
            }
        }

        private static void Multiply(long[] numbers, int firstIndex, int secondIndex)
        {
            numbers[firstIndex] *= numbers[secondIndex];
            
        }

        private static void Swap(long[] numbers, int firstIndex, int secondIndex)
        {
            var tempIndex = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = tempIndex;

           
        }
    }
}
