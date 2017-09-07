using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3_Word_Count
{
    public class task3_Word_Count
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").Split().ToArray();

            var lines = File.ReadAllText("text.txt").ToLower().Split(new[] { '-', ',', ' ', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = new Dictionary<string, int>();
            
            for (int word = 0; word < words.Length; word++)
            {
                var count = 0;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i] == (words[word]))
                    {
                        count++;
                    }
                }
                result.Add(words[word], count);                
            }

            foreach (var item in result.OrderByDescending(x => x.Value))
            {
                //File.AppendAllText("result.txt", $"{item.Key} - {item.Value}{Environment.NewLine}");
                Console.WriteLine($"{item.Key} - {item.Value}");
            }       

            
        }
    }
}
 