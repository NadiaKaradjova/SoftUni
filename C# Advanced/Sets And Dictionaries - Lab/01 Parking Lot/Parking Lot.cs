using System;
using System.Collections.Generic;

namespace _01_Parking_Lot
{
    public class _01_Parking_Lot
    {
        public static void Main()
        {
            var parkingLot = new SortedSet<string>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var line = input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var command = line[0];
                var carNumber = line[1];

                if (command == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else if (command == "OUT")
                {
                    parkingLot.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in parkingLot)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
