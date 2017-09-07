using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Spyfer
{
    public class _3_Spyfer
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count == 1)
                {
                    break;
                }

                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i==0)
                    {
                        if (numbers[i] == numbers[i+1])
                        {
                            numbers.RemoveAt(i + 1);
                            i=0;
                            break;
                        }
                    }
                    else if (i == numbers.Count-1)
                    {
                        if (numbers[i] == numbers[i - 1])
                        {
                            numbers.RemoveAt(i - 1);
                            i=0;
                            break;
                        }
                    }

                    else if (numbers[i] == numbers[i - 1] + numbers[i + 1])
                    {
                        numbers.RemoveAt(i - 1);
                        numbers.RemoveAt(i);
                        i=0;
                        break;
                    }
                }                
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
