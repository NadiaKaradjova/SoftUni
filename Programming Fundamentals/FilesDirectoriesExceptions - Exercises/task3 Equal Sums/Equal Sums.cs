using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_Equal_Sums
{
    public class task3_Equal_Sums
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();
                        
            var index = 0;
            bool isResult = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = i;
                var sumRight = 0;
                var sumLeft = 0;

                for (int right = 0; right < currentNumber; right++)
                {
                    sumRight += numbers[right];
                }

                for (int left = i+1; left < numbers.Length; left++)
                {
                    sumLeft += numbers[left];
                }
                if (sumRight == sumLeft)
                {
                    index = currentNumber;
                    isResult = true;
                }
            }

            if (isResult)
            {
                File.WriteAllText("output.txt", $"{index}");
            }
            else
            {
                File.WriteAllText("output.txt", "no");
            } 
        }
    }
}
