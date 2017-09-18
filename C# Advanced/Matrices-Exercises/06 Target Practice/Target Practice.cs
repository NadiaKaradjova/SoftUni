using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Target_Practice
{
    public class _06_Target_Practice
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimentions[0];
            var cols = dimentions[1];

            var input = Console.ReadLine();
            Queue<char> snake = new Queue<char>(input.ToCharArray());

            var shot = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var shotRow = shot[0];
            var shotCol = shot[1];
            var radius = shot[2];

            var matrix = new char[rows][];   
            
            PopulateMatrix(snake, matrix, rows, cols);
            Shot(matrix, shotRow, shotCol, radius);
            Down(matrix);

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void PopulateMatrix(Queue<char> snake, char[][] matrix, int row, int col)
        {
            var step = 1;
            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                if (step % 2 == 0)//Fill from left
                {
                    var arr = new char[col];
                    for (int c = 0; c < arr.Length; c++)
                    {
                        char currentChar = snake.Dequeue();
                        arr[c] = currentChar;
                        snake.Enqueue(currentChar);
                    }
                    matrix[i] = arr;
                }
                else//Fill from right
                {
                    var arr = new char[col];
                    for (int j = arr.Length - 1; j >= 0; j--)
                    {
                        char currentChar = snake.Dequeue();
                        arr[j] = currentChar;
                        snake.Enqueue(currentChar);
                    }
                    matrix[i] = arr;
                }
                step++;
            }
        }

        private static void Shot(char[][] matrix, int shotRow, int shotCol, int radius)
        {
            if (radius == 0)
            {
                matrix[shotRow][shotCol] = ' ';
                return;
            }
            else
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                    {
                        if (((i - shotRow) * (i - shotRow) + (j - shotCol) * (j - shotCol)) <= radius * radius)
                        {
                            matrix[i][j] = ' ';
                        }
                    }
                }
            }                
        }

        private static void Down(char[][] matrix)
        {
            var length = matrix[0].Length;           

            for (int j = 0; j < length; j++)
            {
                var curentCol = new Stack<char>();

                for (int i = 0; i < matrix.Length; i++)
                {
                    if (matrix[i][j] != ' ')
                    {
                        curentCol.Push(matrix[i][j]);
                        matrix[i][j] = ' ';
                    }                    
                }

                for (int i = matrix.Length - 1; i >= 0; i--)
                {
                    if (curentCol.Count <= 0)
                    {
                        break;
                    }
                    matrix[i][j] = curentCol.Pop();
                }                
            }
        }
    }
}