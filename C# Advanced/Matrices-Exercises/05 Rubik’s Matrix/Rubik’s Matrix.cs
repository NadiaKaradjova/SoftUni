using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rubik_s_Matrix
{
    public class _05_Rubik_s_Matrix
    {
        public static void Main()
        {

            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimentions[0];
            var cols = dimentions[1];

            var matrix = new int[rows][];

            var number = 1;
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = number;
                    number++;
                }
            }
           
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                
                    var column = int.Parse(input[0]);
                    var direction = input[1];
                    var move = int.Parse(input[2]);

                switch (direction)
                {
                    case "up":Up(matrix, move, column);
                        break; 
                    case "down": Down(matrix, move, column);
                        break;
                    case "left": Left(matrix, move, column);
                        break;
                    case "right":
                        Right(matrix, move, column);
                        break;
                }
            }

            number = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == number)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        
                        for (int x = 0; x < rows; x++)
                        {
                            
                            for (int y = 0; y < cols; y++)
                            {
                                if (matrix[x][y] == number)
                                {
                                    var tempRow = x;
                                    var tempCol = y;
                                    Console.WriteLine($"Swap ({i}, {j}) with ({tempRow}, {tempCol})");
                                    var temp = matrix[i][j];
                                    matrix[i][j] = matrix[tempRow][tempCol];
                                    matrix[tempRow][tempCol] = temp;
                                    break;                                 
                                }
                            }
                        }
                    }
                    number++;
                }
            }
        }

        private static void Right(int[][] matrix, int move, int column)
        {
            var length = matrix[0].Length;
            move = move % length;
            var row = column;
            for (int j = 0; j < move; j++)
            {
                var temp = matrix[row][length - 1];
                for (int x = length - 1; x > 0; x--)
                {
                    matrix[row][x] = matrix[row][x - 1];
                }
                matrix[row][0] = temp;

            }
        }

        private static void Left(int[][] matrix, int move, int column)
        {
            var length = matrix[0].Length;
            move = move % length;
            var row = column;
            for (int j = 0; j < move; j++)
            {
                var temp = matrix[row][0];
                for (int x = 0; x < length - 1; x++)
                {
                    matrix[row][x] = matrix[row][x+1];
                }
                matrix[row][length-1] = temp;
            }
        }

        private static void Down(int[][] matrix, int move, int column)
        {
            move = move % matrix.Length;
            for (int j = 0; j < move; j++)
            {
                var temp = matrix[matrix.Length - 1][column];
                for (int x = matrix.Length - 1; x > 0; x--)
                {
                    matrix[x][column] = matrix[x - 1][column];
                }
                matrix[0][column] = temp;
            }
        }

        private static void Up(int[][] matrix, int move, int column)
        {
            move = move % matrix.Length;
            for (int j = 0; j < move; j++)
            {
                var temp = matrix[0][column];
                for (int x = 0; x < matrix.Length-1; x++)
                {
                    matrix[x][column] = matrix[x+1][column];
                }
                matrix[matrix.Length - 1][column] = temp;
            }
        }
    }
}
