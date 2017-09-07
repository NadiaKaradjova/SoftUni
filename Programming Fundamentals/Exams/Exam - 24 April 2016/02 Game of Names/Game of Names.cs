using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Game_of_Names
{
    public class _02_Game_of_Names
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var winnerName = "";
            var winnerPoints = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var points = int.Parse(Console.ReadLine());

                foreach (var letter in name)
                {
                    var digit = (int)letter;
                    if (digit%2 == 0)
                    {
                        points += digit;
                    }
                    else
                    {
                        points -= digit;
                    }
                }
                if (points > winnerPoints)
                {
                    winnerPoints = points;
                    winnerName = name;
                }
            }

            Console.WriteLine($"The winner is {winnerName} - {winnerPoints} points");
        }
    }
}
