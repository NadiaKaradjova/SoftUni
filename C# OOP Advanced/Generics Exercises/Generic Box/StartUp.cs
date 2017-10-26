using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBox
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            IList<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                Box<int> boxInt = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.Add(boxInt);
            }
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap(boxes, indexes[0], indexes[1]);

            foreach (var item in boxes)
            {
                Console.WriteLine(item);
            }
        }

        private static void Swap<T>(IList<T> boxes, int i, int i1)
        {
            T temp = boxes[i];
            boxes[i] = boxes[i1];
            boxes[i1] = temp;
        }
    }
}