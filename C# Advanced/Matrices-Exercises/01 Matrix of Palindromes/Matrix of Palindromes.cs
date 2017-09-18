using System;
using System.Linq;

namespace _01_Matrix_of_Palindromes
{
    public class _01_Matrix_of_Palindromes
    {
        public static void Main()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = dimentions[0];
            var cols = dimentions[1];

            var matrix = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new string[cols];
                var index = i;
                for (int j = 0; j < cols; j++)
                {
                    
                    var charString = alphabet[i].ToString() + alphabet[index].ToString() + alphabet[i].ToString();
                    matrix[i][j] = charString;
                    index++;
                }
            }
            
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
    

