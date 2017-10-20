using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        public static void Main()
        {
            IList<Human> humans = new List<Human>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (input.Length > 3)
                {
                    humans.Add(new Citizens(input[0], int.Parse(input[1]), input[2], input[3]));
                }
                else
                {
                    humans.Add(new Rebel(input[0], int.Parse(input[1]), input[2]));
                }
            }

            string buyer = Console.ReadLine();

            while (buyer != "End")
            {
                if (humans.Any(b => b.Name == buyer))
                {
                    var humanBuyer = humans.First(b => b.Name == buyer);
                    humanBuyer.BuyFood();
                }

                buyer = Console.ReadLine();
            }

            var totalFood = 0;
            foreach (var human in humans)
            {
                totalFood += human.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}