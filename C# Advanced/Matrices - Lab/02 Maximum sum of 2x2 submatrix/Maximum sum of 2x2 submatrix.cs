using System;
using System.Linq;

namespace _02_Maximum_sum_of_2x2_submatrix
{
    public class _02_Maximum_sum_of_2x2_submatrix
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            var rows = dimensions.First();
            var cols = dimensions.Last();

            var matrix = new int[rows, cols];
            var resultMatrix = new int[2][];
            var sum = -1;

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    var temp = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (temp > sum)
                    {
                        sum = temp;
                        resultMatrix[0] = new int[] { matrix[i, j], matrix[i, j + 1] };
                        resultMatrix[1] = new int[] { matrix[i + 1, j], matrix[i + 1, j + 1] };
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(string.Join(" ", resultMatrix[i]));
            }
            Console.WriteLine(sum);           
        }
    }
}
