using System;
using System.Collections.Generic;
using System.Text;

namespace task6_Sum_big_numbers
{
    public class Sum_big_numbers
    {
        public static void Main()
        {
            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();

            var countLength = num1.Length.CompareTo(num2.Length);
            var buffer = 0;
            var sum = 0;
            var result = new StringBuilder();

            var temp = new List<int>();

            if (countLength == 0)
            {
                for (int i = num1.Length - 1; i >= 0; i--)
                {
                    sum = (num1[i] - '0') + (num2[i] - '0') + buffer;

                    if (sum >= 10)
                    {
                        sum = sum % 10;
                        buffer = 1;
                        temp.Add(sum);
                    }
                    else
                    {
                        temp.Add(sum);
                        buffer = 0;
                    }
                }
                if (buffer == 1) temp.Add(buffer);
            }

            else if (countLength == -1)
            {
                temp = SumBigNumbers(num1, num2);
            }

            else if (countLength == 1)
            {
                temp = SumBigNumbers(num2, num1);
            }

            temp.Reverse();

            foreach (var item in temp)
            {
                result.Append(item);
            }
            var finalStr = result.ToString().TrimStart('0');

            Console.WriteLine(finalStr);
        }



        public static List<int> SumBigNumbers(string num1, string num2)
        {
            var sum = 0;
            var buffer = 0;
            var temp = new List<int>();

            for (int i = 0; i < num1.Length; i++)
            {
                sum = (num1[num1.Length - 1 - i] - '0') + (num2[num2.Length - 1 - i] - '0') + buffer;

                if (sum >= 10)
                {
                    sum = sum % 10;
                    buffer = 1;
                    temp.Add(sum);
                }
                else if (sum < 10)
                {
                    temp.Add(sum);
                    buffer = 0;
                }
            }

            num2 = num2.Remove(num2.Length - num1.Length, num1.Length);

            for (int i = num2.Length - 1; i >= 0; i--)
            {
                sum = num2[i] - '0' + buffer;

                if (sum >= 10)
                {
                    sum = sum % 10;
                    buffer = 1;
                    temp.Add(sum);
                }
                else
                {
                    temp.Add(sum);
                    buffer = 0;
                }

            }
            if (buffer == 1) temp.Add(buffer);
            return temp;
        }
    }
}
