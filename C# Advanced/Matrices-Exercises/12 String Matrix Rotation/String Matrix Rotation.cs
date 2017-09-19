using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12_String_Matrix_Rotation
{
    public class _12_String_Matrix_Rotation
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var pattern = new Regex(@"([\d]+)");

            var match = pattern.Match(command);
            var degrees = int.Parse(match.Groups[1].Value);
            var rotation = (degrees % 360 )/ 90;


            var matrix = new List<List<char>>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                matrix.Add(input.ToCharArray().ToList());

                input = Console.ReadLine();
            }

            var maxlength = matrix.Max(x => x.Count);

            for (int i = 0; i < matrix.Count; i++)
            {
                if (matrix[i].Count < maxlength)
                {
                    while (matrix[i].Count < maxlength)
                    {
                        matrix[i].Add(' ');
                    }
                }
            }

            if (rotation > 0)
            {
                for (int i = 0; i < rotation; i++)
                {
                    RotateMatrix(matrix);
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }

            
        }

        private static void RotateMatrix(List<List<char>> matrix)
        {
            var result = new List<List<char>>();

            for (int i = 0; i < matrix[0].Count; i++)
            {
                var chars = new List<char>();

                for (int j = matrix.Count -1; j >= 0; j--)
                {
                    chars.Add(matrix[j][i]);
                }
                result.Add(chars);
            }

            matrix.Clear();
            matrix.AddRange(result);
        }
    }
}
