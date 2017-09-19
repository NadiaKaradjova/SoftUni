using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Parking_System
{
    public class _11_Parking_System
    {
        public static void Main()
        {
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var totalRows = dimentions[0];
            var totalCols = dimentions[1];

            var parking = new Dictionary<int, HashSet<int>>();

            var input = Console.ReadLine();

            while (input != "stop")
            {
                var line = input.Split().Select(int.Parse).ToArray();
                var entryRow = line[0];
                var targetRow = line[1];
                var targetCol = line[2];

                if (!isPlaceOccupated(parking, targetRow, targetCol))
                {
                    OccupyPlace(parking, targetRow, targetCol);
                    var distance = Math.Abs(entryRow - targetRow) + targetCol + 1;
                    Console.WriteLine(distance);
                }
                else
                {
                    targetCol = FindEmptySpot(parking[targetRow], totalCols, targetCol);
                    if (targetCol == 0)
                    {
                        Console.WriteLine($"Row {targetRow} full");
                    }
                    else
                    {
                        OccupyPlace(parking, targetRow, targetCol);
                        var distance = Math.Abs(entryRow - targetRow) + targetCol + 1;
                        Console.WriteLine(distance);
                    }
                }

                input = Console.ReadLine();
            }
        }

        private static int FindEmptySpot(HashSet<int> parkingRow, int totalCols, int targetCol)
        {
            var targetColIndex = 0;
            var min = int.MaxValue;
            if (parkingRow.Count == totalCols - 1)
            {
                return targetColIndex;
            }
            else
            {
                for (int i = 1; i < totalCols; i++)
                {
                    int currentDistance = Math.Abs(targetCol - i);
                    if (!parkingRow.Contains(i) && currentDistance < min)
                    {
                        targetColIndex = i;
                        min = currentDistance;
                    }
                }
                return targetColIndex;
            }
        }

        private static bool isPlaceOccupated(Dictionary<int, HashSet<int>> parking, int targetRow, int targetCol)
        {
            return parking.ContainsKey(targetRow) && parking[targetRow].Contains(targetCol);
        }

        private static void OccupyPlace(Dictionary<int, HashSet<int>> parking, int targetRow, int targetCol)
        {
            if (!parking.ContainsKey(targetRow))
            {
                parking[targetRow] = new HashSet<int>();
            }
            parking[targetRow].Add(targetCol);
        }
    }
}
