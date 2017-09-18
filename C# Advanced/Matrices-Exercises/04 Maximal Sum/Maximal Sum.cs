using System;
using System.Linq;

namespace _04_Maximal_Sum
{
    public class _04_Maximal_Sum
    {
        public static void Main()
        {

            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimentions[0];
            var cols = dimentions[1];

            var matrix = new int[rows][];
            var resultMatrix = new int[3][];

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[i] = input;
            }

            var sum = int.MinValue;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    var firstRow = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2];
                    var secondRow = matrix[i+1][j] + matrix[i+1][j + 1] + matrix[i+1][j + 2];
                    var thirdRow = matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];
                    var temp = firstRow + secondRow + thirdRow;
                    if (sum < temp)
                    {
                        sum = temp;
                        var index = i;
                        for (int x = 0; x < resultMatrix.Length; x++)
                        {
                            
                            resultMatrix[x] = new int[] { matrix[index][j], matrix[index][j + 1], matrix[index][j + 2] };
                            index++;
                        }
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");
            foreach (var row in resultMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
