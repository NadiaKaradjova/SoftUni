using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Multiply_Targeted_Cell
{
    public class _05_Multiply_Targeted_Cell
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = dimentions[0];
            var cols = dimentions[1];

            var numbers = new int[rows, cols] ;

            for (int i = 0; i < rows; i++)
            {
                var values = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    numbers[i, j] = values[j];
                }
            }

            var targetCell = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sum = 0;

            for (int i = targetCell[0]-1; i <= targetCell[0]+1; i++)
            {
                for (int j = targetCell[1]-1; j <= targetCell[1] + 1; j++)
                {
                    if (!(i == targetCell[0] && j == targetCell[1]))
                    {
                        sum += numbers[i, j];
                        numbers[i, j] *= numbers[targetCell[0], targetCell[1]];
                    }                    
                }
            }

            numbers[targetCell[0], targetCell[1]] *= sum; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(numbers[i, j]);
                    if (j < cols - 1)
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }

        }
    }
}
