using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5___Blur_Filter
{
    public class Problem_5___Blur_Filter
    {
        public static void Main()
        {
            var blur = int.Parse(Console.ReadLine());
            var matrixParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = matrixParameters[0];
            var cols = matrixParameters[1];

            var matrix = new long[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().Split().Select(long.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            var target = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var targetRow = target[0];
            var targetCol = target[1];

            for (int i = targetRow-1; i <= targetRow+1; i++)
            {
                for (int j = targetCol-1; j <= targetCol+1; j++)
                {
                    if (i >= 0 && i < rows && j >= 0  && j<cols)
                    {
                        matrix[i, j] += blur;
                    }
                }

            }

            Print(matrix, rows, cols);
        }

        private static void Print(long[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <cols; j++)
                {
                    Console.Write(matrix[i,j]);
                    if(j < cols - 1)
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
