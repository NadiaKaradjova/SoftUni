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

            var sumTechnical = 0.0;
            var sumTheoretical = 0.0;
            var sumPractical = 0.0;
            
            for (int i = 0; i < n; i++)
            {
                var distanceMiles = long.Parse(Console.ReadLine());
                var cargoTons = double.Parse(Console.ReadLine());
                var teamName = Console.ReadLine();

                var fuel = 0.7 * distanceMiles * 1600 * 2.5;
                var cargo = 1.5 * cargoTons * 1000;

                var currentEarnedMoney = cargo - fuel;

                if (teamName == "Technical")
                {
                    sumTechnical += currentEarnedMoney;
                }
                else if (teamName == "Theoretical")
                {
                    sumTheoretical += currentEarnedMoney;
                }
                else if (teamName == "Practical")
                {
                    sumPractical += currentEarnedMoney;
                }
            }

            double winSum = Math.Max(sumPractical, Math.Max(sumTechnical, sumTheoretical));

            Console.WriteLine(winSum);
           
            if (winSum == sumPractical)
            {
                Console.WriteLine($"The Practical Trainers win with ${sumPractical:f3}.");
            }
            else if (winSum == sumTechnical)
            {
                Console.WriteLine($"The Technical Trainers win with ${sumTechnical:f3}.");
            }
            else if (winSum == sumTheoretical)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${sumTheoretical:f3}.");
            }
        }
    }
}
