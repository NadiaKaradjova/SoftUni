using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Crossfire
{
    public class _09_Crossfire
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimentions[0];
            var cols = dimentions[1];

            var matrix = new List<List<int>>();

            var number = 1;
            for (int i = 0; i < rows; i++)  
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < cols; j++)
                {
                    matrix[i].Add(number);
                    number++;
                }
            }

            var input = Console.ReadLine();

            while (input != "Nuke it from orbit")
            {
                var line = input.Split().Select(int.Parse).ToArray();
                var targetRow = line[0];
                var targetCol = line[1];
                var radius = line[2];

                for (int i = targetRow - radius; i <= targetRow + radius; i++)
                {
                    if (isInMatrix(i, targetCol, matrix) )
                    {
                        matrix[i][targetCol] = 0;
                    }
                }

                for (int j = targetCol - radius; j <= targetCol + radius; j++)
                {
                    if (isInMatrix(targetRow, j, matrix))
                    {
                        matrix[targetRow][j] = 0;
                    }
                }

                FilterMatrix(matrix);

                input = Console.ReadLine();
            } 

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void FilterMatrix(List<List<int>> matrix)
        {
            for (int i = matrix.Count -1; i >= 0; i--)
            {
                for (int j = matrix[i].Count - 1; j >= 0; j--)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i].RemoveAt(j);
                    }                    
                }

                if (matrix[i].Count == 0)
                {
                    matrix.RemoveAt(i);
                }
            }
        }

        private static bool isInMatrix(int currentRow, int currentCol, List<List<int>> matrix)
        {
            if (currentRow >= 0 && currentRow < matrix.Count && currentCol >= 0 && currentCol < matrix[currentRow].Count)
            {
                return true;
            }
            return false;
        }        
    }
}