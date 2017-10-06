using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    public class Rectangle_Intersection
    {
        public static void Main()
        {
            var rectangles = new Dictionary<string, Rectangle>();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input[0]; i++)
            {
                var rectangleInfo = Console.ReadLine().Split();
                var id = rectangleInfo[0];
                var width = double.Parse(rectangleInfo[1]);
                var height = double.Parse(rectangleInfo[2]);
                var topLeftX = double.Parse(rectangleInfo[3]);
                var topLeftY = double.Parse(rectangleInfo[4]);

                var currentRec = new Rectangle(id, width, height, topLeftX, topLeftY);
                rectangles[id] = currentRec;
            }

            for (int i = 0; i < input[1]; i++)
            {
                var checkIds = Console.ReadLine().Split();
                var result = rectangles[checkIds[0]].IntersectWith(rectangles[checkIds[1]]);
                Console.WriteLine(result.ToString().ToLower());
            }
        }
    }
}
