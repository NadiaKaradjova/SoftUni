using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Pokemon_Don_t_Go
{
    public class _2_Pokemon_Don_t_Go
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var sum = 0;

            while (input.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < input.Count)
                {
                    var temp = input[index];
                    input.RemoveAt(index);

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= temp)
                        {
                            input[i] += temp;
                        }
                        else
                        {
                            input[i] -= temp;
                        }
                    }
                    sum += temp;
                }

                else if (index >= input.Count)
                {
                    var temp = input[input.Count - 1];
                    input.RemoveAt(input.Count-1);
                    input.Add(input[0]);
                    
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= temp)
                        {
                            input[i] += temp;
                        }
                        else
                        {
                            input[i] -= temp;
                        }
                    }
                    sum += temp;
                }

                else if (index < 0)
                {
                    var temp = input[0];
                    input.RemoveAt(0);
                    input.Insert(0, input[input.Count-1]);

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= temp)
                        {
                            input[i] += temp;
                        }
                        else
                        {
                            input[i] -= temp;
                        }
                    }
                    sum += temp;
                }
            }

        Console.WriteLine(sum);
        }
    }
}