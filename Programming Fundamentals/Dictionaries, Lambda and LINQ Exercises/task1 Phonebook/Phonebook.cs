using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_Phonebook
{
    public class task1_Phonebook
    {
        public static void Main()
        {

            var phoneBook = new SortedDictionary<string, string>();

            while (true)
            {
                var text = Console.ReadLine();

                if (text == "END")
                {
                    break;
                }
                
                var input = text.Split(' ').ToList();
                                
                if (input[0] == "A")
                {
                    phoneBook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (!phoneBook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", input[1], phoneBook[input[1]]);
                    }
                }
            }           
        }
    }
}
