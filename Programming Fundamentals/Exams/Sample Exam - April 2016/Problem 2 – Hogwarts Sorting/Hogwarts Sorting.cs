using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Hogwarts_Sorting
{
    public class Problem_2___Hogwarts_Sorting
    {
        public static void Main()
        {
            var homes = new Dictionary<string, int>()
            {
                {"Gryffindor", 0},
                {"Slytherin", 0},
                {"Ravenclaw", 0},
                {"Hufflepuff", 0}
            };

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var sum = 0;
                string initials = "";
                var names = input.Split().ToArray();
                var firstName = names[0];
                var secondName = names[1];

                initials = firstName.First().ToString() + secondName.First().ToString();

                foreach (var letter in firstName)
                {
                    sum += letter;
                    
                }
                foreach (var letter in secondName)
                {
                    sum += letter;
                }
                var home = FindHome(sum);
                Console.WriteLine($"{home} {sum.ToString()+initials}");

                if (homes.ContainsKey(home))
                {
                    homes[home]++;
                }
            }

            Console.WriteLine();
            foreach (var home in homes)
            {
                Console.WriteLine($"{home.Key}: {home.Value}");
            }
        }

        private static string FindHome(int sum)
        {
            var reminder = sum % 4;
            var home = "";
            switch (reminder)
            {
                case 0: home = "Gryffindor";
                    break;
                case 1: home ="Slytherin";
                    break;
                case 2: home ="Ravenclaw";
                    break;
                case 3: home ="Hufflepuff";
                    break;
            }
            return home;
        }
    }
}
