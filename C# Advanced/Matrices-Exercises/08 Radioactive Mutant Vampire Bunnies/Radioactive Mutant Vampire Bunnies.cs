using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Radioactive_Mutant_Vampire_Bunnies
{
    public class _08_Radioactive_Mutant_Vampire_Bunnies
    {
        private static int playerCol = 0;
        private static int playerRow = 0;
        private static bool isDied = false;
        private static bool isEscaped = false;

        public static void Main()
        {
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimentions[0];
            var cols = dimentions[1];

            var matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine();
                matrix[i] = input.ToCharArray();

                if (input.Contains('P'))
                {
                    var index = input.IndexOf('P');
                    playerCol = index;
                    playerRow = i;
                }
            }

            Moves(matrix);
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
            if (isDied || !isEscaped)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
            else
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
        }

        private static void Moves(char[][] matrix)
        {
            var moves = Console.ReadLine();

            for (int i = 0; i < moves.Length; i++)
            {
                if (isDied || isEscaped)
                {
                    break;
                }

                switch (moves[i])
                {
                    case 'U':
                        MoveUp(matrix);
                        break;
                    case 'D':
                        MoveDown(matrix);
                        break;
                    case 'L':
                        MoveLeft(matrix);
                        break;
                    case 'R':
                        MoveRight(matrix);
                        break;
                }

                MultiplicationOfBunnies(matrix);
            }
        }

        private static void MultiplicationOfBunnies(char[][] matrix)
        {
            var indexOfBunny = new List<int[]>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 'B')
                    {
                        indexOfBunny.Add(new int[] { i, j });
                    }
                }
            }

            foreach (var bunny in indexOfBunny)
            {
                var row = bunny[0];
                var col = bunny[1];

                //up
                if (row > 0)
                {
                    if (matrix[row - 1][col] == 'P')
                    {
                        isDied = true;
                        isEscaped = false;
                    }
                    matrix[row - 1][col] = 'B';
                }

                //down
                if (row < matrix.Length - 1)
                {
                    if (matrix[row + 1][col] == 'P')
                    {
                        isDied = true;
                        isEscaped = false;
                    }
                    matrix[row + 1][col] = 'B';
                }

                //left
                if (col > 0)
                {
                    if (matrix[row][col - 1] == 'P')
                    {
                        isDied = true;
                        isEscaped = false;
                    }
                    matrix[row][col - 1] = 'B';
                }

                //right
                if (col < matrix[0].Length - 1)
                {
                    if (matrix[row][col + 1] == 'P')
                    {
                        isDied = true;
                        isEscaped = false;
                    }
                    matrix[row][col + 1] = 'B';
                }
            }
        }

        private static void MoveRight(char[][] matrix)
        {
            if (playerCol == matrix[0].Length - 1)
            {
                matrix[playerRow][playerCol] = '.';
                isEscaped = true;
            }
            else if (matrix[playerRow][playerCol + 1] == 'B')
            {
                isDied = true;
                matrix[playerRow][playerCol] = '.';
                playerCol++;
            }
            else
            {
                matrix[playerRow][playerCol] = '.';
                matrix[playerRow][playerCol + 1] = 'P';
                playerCol++;
            }
        }

        private static void MoveLeft(char[][] matrix)
        {
            if (playerCol == 0)
            {
                matrix[playerRow][playerCol] = '.';
                isEscaped = true;
            }
            else if (matrix[playerRow][playerCol - 1] == 'B')
            {
                isDied = true;
                matrix[playerRow][playerCol] = '.';
                playerCol--;
            }
            else
            {
                matrix[playerRow][playerCol] = '.';
                matrix[playerRow][playerCol - 1] = 'P';
                playerCol--;
            }

        }

        private static void MoveDown(char[][] matrix)
        {
            if (playerRow == matrix.Length - 1)
            {
                matrix[playerRow][playerCol] = '.';
                isEscaped = true;
            }
            else if (matrix[playerRow + 1][playerCol] == 'B')
            {
                isDied = true;
                matrix[playerRow][playerCol] = '.';
                playerRow++;
            }
            else
            {
                matrix[playerRow][playerCol] = '.';
                matrix[playerRow + 1][playerCol] = 'P';
                playerRow++;
            }
        }

        private static void MoveUp(char[][] matrix)
        {
            if (playerRow == 0)
            {
                matrix[playerRow][playerCol] = '.';
                isEscaped = true;
            }
            else if (matrix[playerRow - 1][playerCol] == 'B')
            {
                isDied = true;
                matrix[playerRow][playerCol] = '.';
                playerRow--;
            }
            else
            {
                matrix[playerRow][playerCol] = '.';
                matrix[playerRow - 1][playerCol] = 'P';
                playerRow--;
            }
        }
    }
}
