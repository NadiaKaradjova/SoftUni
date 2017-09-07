using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Charity_Marathon
{
    public class Problem_1_Charity_Marathon
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var laps = int.Parse(Console.ReadLine());
            var lengthTrack = int.Parse(Console.ReadLine());
            var capacityTrack = int.Parse(Console.ReadLine());
            var moneyPerKilometer = double.Parse(Console.ReadLine());

            long totalRunners = 0;
            var capacity = capacityTrack * days;

            if (capacity > runners)
            {
                totalRunners = runners;
            }
            else
            {
                totalRunners = capacity;
            }

            long totalMeters = totalRunners * laps * lengthTrack;
            long totalKm = totalMeters / 1000;

            double totalMoney = totalKm * moneyPerKilometer;

            Console.WriteLine($"Money raised: {Math.Round(totalMoney,2):f2}");

        }
    }
}
