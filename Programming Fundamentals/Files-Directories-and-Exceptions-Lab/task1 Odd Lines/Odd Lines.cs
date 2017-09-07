using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1_Odd_Lines
{
    public class task1_Odd_Lines
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("TextFile1.txt");

            if (!File.Exists("result.txt"))
            {
                File.Create("result.txt");
            } 

            var oddLines = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (i%2 != 0)
                {
                    oddLines.Add(lines[i]);
                }

            }
            File.WriteAllLines("result.txt", oddLines);
           
        }
        
    }
}
