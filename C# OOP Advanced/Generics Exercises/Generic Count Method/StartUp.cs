using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethod
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            IList<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(box);
            }

            var elementToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(Check(boxes, elementToCompare));
        }

        public static int Check<T>(IList<Box<T>> boxes, T elementToCompare) where T : IComparable
        {
            return boxes.Count(b => b.Value.CompareTo(elementToCompare) > 0);
        }
    }
}