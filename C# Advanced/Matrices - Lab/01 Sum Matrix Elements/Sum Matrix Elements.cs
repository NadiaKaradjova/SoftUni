using System;
using System.Linq;

namespace _01_Sum_Matrix_Elements
{
    public class _01_Sum_Matrix_Elements
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            var rows = dimensions.First();
            var cols = dimensions.Last();

            var matrix = new int[rows, cols];
            var sum = 0;

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split(new [] { ", " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
