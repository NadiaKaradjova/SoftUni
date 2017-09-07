using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4_Merge_Files
{
    public class task4_Merge_Files
    {
        public static void Main()
        {
            var firstFile = File.ReadAllText("file1.txt").Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var secondFile = File.ReadAllText("file2.txt").Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = firstFile.Concat(secondFile).OrderBy(x => x).ToList();

            File.WriteAllLines("result.txt", result);
        }
    }
}
