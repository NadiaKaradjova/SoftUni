using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Entertrain
{
    public class _02_Entertrain
    {
        public static void Main()
        {
            var locomotivePower = int.Parse(Console.ReadLine());
            var result = new List<int>();
            var input = Console.ReadLine();

            while (input != "All ofboard!")
            {
                var wagon = int.Parse(input);
                result.Add(wagon);
                var average = result.Average();
                var total = result.Sum();

                var index = 0;

                if (total > locomotivePower)
                {
                    double temp = double.MaxValue;
                    for (int i = 0; i < result.Count; i++)
                    {
                        var min = Math.Abs(result[i] - average);

                        if (temp > min)
                        {
                            temp = min;
                            index = i;
                        }
                    }
                    result.RemoveAt(index);
                }

                input = Console.ReadLine();
            }

            result.Reverse();
            result.Add(locomotivePower);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
