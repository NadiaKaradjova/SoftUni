using System;
using System.Linq;

namespace task6_Rectangle_Position
{
    public class task6_Rectangle_Position
    {
        public static void Main()
        {            
            var rec1 = ReadRectangle();
            var rec2 = ReadRectangle();

            Console.WriteLine(IsInside(rec1, rec2) ? "Inside": "Not Inside");            
        }

        public static Rectangle ReadRectangle()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rec = new Rectangle() { Top = input[0], Left = input[1], Width= input[2], Height= input[3] } ;
            return rec;            
        }

        public static bool IsInside(Rectangle rec1, Rectangle rec2)
        {
            bool isInsideRec = false;                   

            if (rec1.Left <= rec2.Left && rec1.Right <= rec2.Right && rec1.Top >= rec2.Top && rec1.Bottom <= rec2.Bottom)
            {
                isInsideRec = true;
            }
            
            return isInsideRec;
        }        
    }
}
