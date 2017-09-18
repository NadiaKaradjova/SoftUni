using System;
using System.Linq;

namespace _03_2x2_Squares_in_Matrix
{
    public class _03_2x2_Squares_in_Matrix
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimentions[0];
            var cols = dimentions[1];

            var matrix = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                matrix[i] = input;
            }

            var count = 0;

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    if (matrix[i][j] == matrix[i][j+1] &&
                        matrix[i][j] == matrix[i+1][j] && matrix[i][j] == matrix[i+1][j+1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
