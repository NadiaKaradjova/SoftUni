using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_Palindromes
{
    public class task4_Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] { ',', ' ', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            var palidromes = new HashSet<string>();
           
            foreach (var word in text)
            {
                var n = 0;
                if (word.Length == 1)
                {
                    palidromes.Add(word);
                }
                else
                {
                    for (int i = 0; i < word.Length / 2; i++)
                    {
                        var currentIndex = i;
                        var firstElement = word[currentIndex];
                        var lastElement = word[word.Length - 1 - currentIndex];
                        n = firstElement.CompareTo(lastElement);
                        
                        if (n != 0)
                        {
                            break;
                        }                        
                    }

                    if (n == 0)
                    {
                        palidromes.Add(word);
                    }                    
                }               
            }
            var sorted = palidromes.OrderBy(x => x);
            Console.WriteLine(string.Join(", ", sorted));
        }
    }
}
