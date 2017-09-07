using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Files_new
{
    public class _04_Files_new
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = new List<Files>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('\\').ToList();

                var root = input.First();
                var file = input.Last().Split(';');

                var fileName = file[0];
                var size = long.Parse(file[1]);

                var currentFile = new Files();

                if (result.Any(x => x.Root == root))
                {
                    currentFile = result.First(x => x.Root == root);

                    if (!currentFile.File.ContainsKey(fileName))
                    {
                        currentFile.File[fileName] = 0;
                    }
                    currentFile.File[fileName] = size;
                }
                else
                {
                    currentFile.Root = root;
                    currentFile.File = new Dictionary<string, long>();
                    currentFile.File[fileName] = size;
                    result.Add(currentFile);
                }
            }

            var command = Console.ReadLine().Split().ToArray();
            var extentionForSearch = "." + command[0];
            var rootForSearch = command[2];

            if (result.Any(x => x.Root == rootForSearch))
            {
                foreach (var item in result.Where(x => x.Root == rootForSearch))
                {
                    var files = item.File.Where(x => x.Key.EndsWith(extentionForSearch)).OrderByDescending(y => y.Value).ThenBy(z => z.Key)
                        .ToDictionary(a => a.Key, b => b.Value);

                    if (files.Count > 0)
                    {
                        foreach (var file in files)
                        {
                            Console.WriteLine($"{file.Key} - {file.Value} KB");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }

    public class Files
    {
        public string Root { get; set; }
        public Dictionary<string, long> File { get; set; }

    }
}
