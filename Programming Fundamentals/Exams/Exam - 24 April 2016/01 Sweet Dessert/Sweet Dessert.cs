using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sweet_Dessert
{
    public class _01_Sweet_Dessert
    {
        public static void Main()
        {

            var cash = double.Parse(Console.ReadLine());
            var numberOfGuests = long.Parse(Console.ReadLine());
            var priceBananas = double.Parse(Console.ReadLine());
            var priceEggs = double.Parse(Console.ReadLine());
            var priceBerries = double.Parse(Console.ReadLine());

            var sets = Math.Ceiling(numberOfGuests / 6.0);

            var sum = sets * 2 * priceBananas + sets * 4 * priceEggs + sets * 0.2 * priceBerries;

            if (sum <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(sum-cash):f2}lv more.");
            }

        }
    }
}
