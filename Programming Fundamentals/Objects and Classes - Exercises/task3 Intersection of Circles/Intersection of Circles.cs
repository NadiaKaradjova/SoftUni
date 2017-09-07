using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_Intersection_of_Circles
{
    public class task3_Intersection_of_Circles
    {
        public static void Main()
        {
            var circleFirst = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var c1 = new Circle()
            {
                Center = new Point() { X = circleFirst[0], Y = circleFirst[1] },
                Radius = circleFirst[2]
            };
            var circleSecond = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var c2 = new Circle()
            {
                Center = new Point() { X = circleSecond[0], Y = circleSecond[1] },
                Radius = circleSecond[2]
            };

            Console.WriteLine(Intersect(c1, c2) ? "Yes" : "No");

        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            bool isInter = false; 
            var sideA = Math.Abs(c1.Center.X - c2.Center.X);
            var sideB = Math.Abs(c1.Center.Y - c2.Center.Y);
            var d = Math.Sqrt(sideA * sideA + sideB * sideB);
            if (d<=c1.Radius+c2.Radius)
            {
                isInter = true;
            }

            return isInter;
        }




        public class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
