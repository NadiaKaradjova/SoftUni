using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Splinter_Trip
{
    public class _1_Splinter_Trip
    {
        public static void Main()
        {
            var distance = decimal.Parse(Console.ReadLine());
            var tank = decimal.Parse(Console.ReadLine());
            var heavyWinds = decimal.Parse(Console.ReadLine());

            var fuelNoHeavy = (distance - heavyWinds) * 25;
            var fuelWithHeavy = heavyWinds * 25 * 1.5m;

            var fuel = (fuelNoHeavy + fuelWithHeavy) * 1.05m;

            if (fuel <= tank)
            {
                Console.WriteLine($"Fuel needed: {fuel:f2}L");
                Console.WriteLine($"Enough with {tank-fuel:f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"Fuel needed: {fuel:f2}L");
                Console.WriteLine($"We need {fuel-tank:f2}L more fuel.");
            }
        }
    }
}
