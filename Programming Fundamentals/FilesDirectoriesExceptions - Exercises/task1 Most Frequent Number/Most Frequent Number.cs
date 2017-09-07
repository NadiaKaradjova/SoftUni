using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task1_Most_Frequent_Number
{
    public class task1_Most_Frequent_Number
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("text.txt").Split().Select(int.Parse).ToArray();

            int count = 0;
            int index = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                var currentNumber = numbers[i];
                int currentCount = 1;

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if( currentNumber == numbers[j])
                    {
                        currentCount++;
                    }
                }
                if (currentCount > count)
                {
                    count = currentCount;
                    index = currentNumber;
                }
            }

            File.WriteAllText("result.txt", $"{index}");
        }
    }
}
