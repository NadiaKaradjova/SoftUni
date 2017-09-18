using System;

namespace _04_Pascal_Triangle
{
    public class _04_Pascal_Triangle
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var jaggetArray = new long[n][];

            for (int i = 0; i < n; i++)
            {
                jaggetArray[i] = new long[i + 1];
                jaggetArray[i][0] = 1;
                jaggetArray[i][jaggetArray[i].Length - 1] = 1;

                for (int j = 1; j < jaggetArray[i].Length - 1; j++)
                {
                    jaggetArray[i][j] = jaggetArray[i - 1][j - 1] + jaggetArray[i - 1][j];
                }
            }

            foreach (var row in jaggetArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
