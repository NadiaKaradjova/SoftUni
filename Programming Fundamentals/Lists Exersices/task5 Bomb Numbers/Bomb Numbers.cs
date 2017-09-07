using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string[] input = Console.ReadLine().Split();

        int number = int.Parse(input[0]);
        int power = int.Parse(input[1]);

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == number)
            {
                int left = Math.Max(i - power, 0);

                int right = Math.Min(i + power, numbers.Count - 1);

                int lenght = right - left + 1;

                numbers.RemoveRange(left, lenght);
                i = 0;
            }
        }
        Console.WriteLine(numbers.Sum());
    }
}