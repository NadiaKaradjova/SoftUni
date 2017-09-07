using System;
using System.Linq;


namespace task4_Distance_Between_Points
{
    public class task4_Distance_Between_Points
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                var point = new Point();
                var coordinatePoint = Console.ReadLine().Split().Select(int.Parse).ToArray();
                point.X = coordinatePoint[0];
                point.Y = coordinatePoint[1];
                points[i] = point;
            }
                        
            FindClosestPoints(points);

        }

        public static void FindClosestPoints(Point[] points)
        {
            var n = points.Length;
            double closest = double.MaxValue;
            var point1 = new Point();
            var point2 = new Point();
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    var sideA = Math.Abs(points[i].X - points[j].X);
                    var sideB = Math.Abs(points[i].Y - points[j].Y);
                    var distance = Math.Sqrt(sideA * sideA + sideB * sideB);

                    if (distance < closest)
                    {
                        closest = distance;
                        point1.X = points[i].X;
                        point1.Y = points[i].Y;
                        point2.X = points[j].X;
                        point2.Y = points[j].Y;
                    }
                }
            }

            Console.WriteLine($"{closest:f3}");
            Console.WriteLine($"({point1.X}, {point1.Y})");
            Console.WriteLine($"({point2.X}, {point2.Y})");
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
