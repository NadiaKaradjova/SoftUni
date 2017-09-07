
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace _01_Trainers
{
    public class _01_Trainers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, decimal>()
            {
                { "Technical",0},
                { "Theoretical",0},
                { "Practical",0}
            };

            for (int i = 0; i < n; i++)
            {
                var distanceMiles = long.Parse(Console.ReadLine());
                var cargoTons = decimal.Parse(Console.ReadLine());
                var teamName = Console.ReadLine().Trim();

                var fuel = 0.7m * distanceMiles * 1600 * 2.5m;
                var cargo = 1.5m * cargoTons * 1000;

                var currentEarnedMoney = cargo - fuel;

                result[teamName] += currentEarnedMoney;

            }

            var winner = result.OrderByDescending(x => x.Value).First();
            Console.WriteLine($"The {winner.Key} Trainers win with ${winner.Value:f3}.");
        }
    }
}


    
