using System;
using System.Linq;

namespace _07_Lego_Blocks
{
    public class _07_Lego_Blocks
    {
        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine());

            var firstJagget = new int[rows][];
            var secondJagget = new int[rows][];
            var resultJagget = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                firstJagget[i] = input;
            }
            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                Array.Reverse(input);
                secondJagget[i] = input;
            }

            for (int i = 0; i < rows; i++)
            {                              
                resultJagget[i] = firstJagget[i].Concat(secondJagget[i]).ToArray();               
            }

            var sumElements = resultJagget[0].Length;
            var sumCells = 0;
            bool isEquals = true;

            for (int i = 1; i < rows; i++)
            {
                var tempSum = resultJagget[i].Length;

                if (tempSum != sumElements)
                {
                    foreach (var row in resultJagget)
                    {
                        sumCells += row.Length;
                    }
                    Console.WriteLine($"The total number of cells is: {sumCells}");
                    isEquals = false;
                    break;
                } 
            }

            if (isEquals)
            {
                foreach (var row in resultJagget)
                {
                    Console.WriteLine("[" + string.Join(", ", row) + "]");
                }
            }
        }
    }
}
