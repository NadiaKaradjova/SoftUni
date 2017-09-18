using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6_Truck_Tour
{
    public class TruckTour
    {
        public static void Main()
        {
            var stations = new Queue<int[]>();
            int stationsCount = int.Parse(Console.ReadLine()); ;

            for (int i = 0; i < stationsCount; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                stations.Enqueue(input);
            }

            for (int j = 0; j < stationsCount; j++)
            {

                if (IsValid(stations, stationsCount))
                {
                    Console.WriteLine(j);
                    break;
                }
                var st = stations.Dequeue();
                stations.Enqueue(st);
            }
        }

        public static bool IsValid(Queue<int[]> stations, int stationsCount)
        {
            var isCurcleCompleted = true;
            long fuelTank = 0;

            for (int i = 0; i < stationsCount; i++)
            {
                var currStation = stations.Dequeue();

                var gas = currStation[0];
                var distance = currStation[1];

                fuelTank += gas - distance;

                if (fuelTank < 0)
                {
                    isCurcleCompleted = false;
                }
                stations.Enqueue(currStation);
            }
            return isCurcleCompleted;
        }

    }
}