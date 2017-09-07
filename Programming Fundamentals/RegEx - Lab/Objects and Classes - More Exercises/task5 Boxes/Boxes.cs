using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_Boxes
{
    public class task5_Boxes
    {
        public static void Main()
        {
            
            var input = Console.ReadLine();
            //var boxes = new List<Box>();

            while (input != "end")
            {
                var line = input.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var linePoint = line[0].Split(':').Select(int.Parse).ToArray();
                var point1 = new Point() { X = linePoint[0], Y = linePoint[1] };
                linePoint = line[1].Split(':').Select(int.Parse).ToArray();
                var point2 = new Point() { X = linePoint[0], Y = linePoint[1] };
                linePoint = line[2].Split(':').Select(int.Parse).ToArray();
                var point3 = new Point() { X = linePoint[0], Y = linePoint[1] };
                linePoint = line[3].Split(':').Select(int.Parse).ToArray();
                var point4 = new Point() { X = linePoint[0], Y = linePoint[1] };

                var box = new Box();
                box.UpperLeft = point1;
                box.UpperRight = point2;
                box.BottomLeft = point3;
                box.BottomRight = point4;

                var width = Point.CalculateWidth(box.UpperLeft, box.UpperRight);
                var height = Point.CalculateHeight(box.UpperLeft, box.BottomLeft);

                var perimeter = Box.CalculatePerimeter(width, height);
                var area = Box.CalculateArea(width, height);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");

                input = Console.ReadLine();
            }            
        }   

        public class Point
        {
            public int X { get;  set; }
            public int Y { get; set; }

            public static int CalculateWidth(Point point1, Point point2)
            {
                var width = Math.Abs(point1.X - point2.X);
                return width;
                
            }
            public static int CalculateHeight(Point point1, Point point2)
            {
                var height = Math.Abs(point1.Y - point2.Y);
                return height;
            }
        }

        public class Box
        {
            public Point UpperLeft { get; set; }
            public Point UpperRight { get; set; }
            public Point BottomLeft { get; set; }
            public Point BottomRight { get; set; }

            public static int CalculatePerimeter(int width, int height)
            {
                var perimeter = 2 * width + 2 * height;
                return perimeter;
            }
            
           public static int CalculateArea(int width, int height)
            {
                var area = width * height;
                return area;
            }

        }
    }
}
