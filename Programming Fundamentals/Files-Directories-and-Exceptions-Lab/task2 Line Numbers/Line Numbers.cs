using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2_Line_Numbers
{
    public class task2_Line_Numbers
    {
        public static void Main()
        {
            
            var file = File.ReadAllLines("text.txt");

            var newfile = new List<string>();

            for (int i = 0; i < file.Length; i++)
            {
                newfile.Add($"{i + 1 }. {file[i]}");
            }

            File.WriteAllLines("result.txt", newfile);

        }
    }
}
