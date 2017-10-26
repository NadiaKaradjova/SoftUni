using System;
using System.Security.Policy;

namespace Tuples
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var name = $"{input[0]} {input[1]}";
            var address = input[2];
            var town = input[3];
            Threeuple<string, string, string> tuple = new Threeuple<string, string, string>(name, address, town);
            Console.WriteLine(tuple);

            input = Console.ReadLine().Split();
            name = input[0];
            var beer = int.Parse(input[1]);
            bool drinkOrNot = (input[2] == "drunk") ? true : false;
            Threeuple<string, int, bool> tuple1 = new Threeuple<string, int, bool>(name, beer, drinkOrNot);
            Console.WriteLine(tuple1);

            input = Console.ReadLine().Split();
            name = input[0];
            var balance = double.Parse(input[1]);
            var bankName = input[2];
            Threeuple<string, double, string> tuple2 = new Threeuple<string, double, string>(name, balance, bankName);
            Console.WriteLine(tuple2);
        }
    }
}
