using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_Index_of_Letters
{
    public class task2_Index_of_Letters
    {
        public static void Main()
        {
            var letters = File.ReadAllText("input.txt");

            var finalLetters = new Dictionary<char, int>();
            foreach (var symbol in letters)
            {
                var position = symbol - 'a';
                finalLetters.Add(symbol, position);
            }

            if (File.Exists("output.txt"))
            {
                File.Delete("output.txt");
            }
            
            
            foreach (var item in finalLetters)
            {
                
                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value}{Environment.NewLine}");
            }
            
        }
    }
}
