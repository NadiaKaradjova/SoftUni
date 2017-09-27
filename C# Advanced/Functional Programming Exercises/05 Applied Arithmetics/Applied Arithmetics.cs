using System;
using System.Linq;


namespace _05_Applied_Arithmetics
{
    public class _05_Applied_Arithmetics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var input = Console.ReadLine();

            Func<int, int> addOperation = x => x + 1;
            Func<int, int> multiplyOperation = x => x * 2;
            Func<int, int> subtractOperation = x => x - 1;

            while (input != "end")
            {

                if (input == "add")
                {
                    for (int i = 0; i < numbers.Length; i++) numbers[i] = addOperation(numbers[i]);
                }
                else if (input == "multiply")
                {
                    for (int i = 0; i < numbers.Length; i++) numbers[i] = multiplyOperation(numbers[i]);
                }
                else if (input == "subtract")
                {
                    for (int i = 0; i < numbers.Length; i++) numbers[i] = subtractOperation(numbers[i]);
                }
                else if (input == "print") Console.WriteLine(string.Join(" ", numbers));

                input = Console.ReadLine();
            }
        }
    }
}
