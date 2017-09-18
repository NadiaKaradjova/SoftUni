using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Phonebook
{
    public class _05_Phonebook
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "search")
            {
                var line = input.Split('-');
                var name = line[0];
                var phoneNumber = line[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = "";
                }
                phonebook[name] = phoneNumber;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "stop")
            {
                
                if (phonebook.ContainsKey(input))
                {
                    var currentName = phonebook.First(x => x.Key == input);
                    Console.WriteLine($"{currentName.Key} -> {currentName.Value}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }                

                input = Console.ReadLine();
            }
        }
    }
}
