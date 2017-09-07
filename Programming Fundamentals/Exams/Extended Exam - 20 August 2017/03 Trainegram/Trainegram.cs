using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Trainegram
{
    public class _03_Trainegram
    {
        public static void Main()
        {

            var pattern = new Regex(@"^(\<\[[^A-Za-z0-9]*?\]\.)(\.\[[A-Za-z0-9]*\]\.)*$");

            var input = Console.ReadLine();

            while (input != "Traincode!")
            {
                var train = pattern.Match(input);

                if (train.Success)
                {
                    Console.WriteLine(train.Groups[0].Value);
                }

                input = Console.ReadLine();
            }
        }
    }
}
