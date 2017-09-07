using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_Text_filter
{
    public class task3_Text_filter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
            var text = Console.ReadLine();            
            
            for (int i = 0; i < bannedWords.Length; i++)
            {
                var currentBanWord = bannedWords[i];                
                var element = new string('*', currentBanWord.Length);
                text = text.Replace(currentBanWord, element);                           
            }
            Console.WriteLine(text);
        }
    }
}
