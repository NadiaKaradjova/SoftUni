using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_Distance_Between_Points
{
    public class task4_Distance_Between_Points
    {
        public static void Main()
        {
            var firstPoint = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondPoint = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var p1 = new Point { X = firstPoint[0], Y = firstPoint[1] };
            var p2 = new Point { X = secondPoint[0], Y = secondPoint[1] };

            Console.WriteLine($"{ CalcDistance(p1, p2):f3}");


        }
        public static double CalcDistance(Point p1, Point p2)
        {
            var sideA = Math.Abs(p1.X - p2.X);
            var sideB = Math.Abs(p1.Y - p2.Y);
            var distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distance;
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
