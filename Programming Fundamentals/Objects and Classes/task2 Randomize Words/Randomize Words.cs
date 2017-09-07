using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_Randomize_Words
{
    public class task2_Randomize_Words
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split();

            var rnd = new Random();
            

            for (int i = 0; i < text.Length; i++)
            {
                var currentWord = text[i];
                var random = rnd.Next(0, text.Length);

                var temp = text[random];             
                text[i] = temp;
                text[random] = currentWord;

            }

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
