using System;
using System.Linq;

namespace _02_Diagonal_Difference
{
    public class _02_Diagonal_Difference
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[i] = input;
            }

            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            
            for (int i = 0, j = n - 1; i < n; i++, j--)
            {
                primaryDiagonalSum += matrix[i][i];
                secondaryDiagonalSum += matrix[i][j];                          
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
