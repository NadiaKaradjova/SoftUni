using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Sweet_Dessert
{
    public class _1_Sweet_Dessert
    {
        public static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());
            var numberOfGuest = int.Parse(Console.ReadLine());
            var priceForBanana = decimal.Parse(Console.ReadLine());
            var priceForEgg = decimal.Parse(Console.ReadLine());
            var priceForBerry = decimal.Parse(Console.ReadLine());

            var sets = Math.Ceiling(numberOfGuest/6.0m);            

            var total = sets * 2 *priceForBanana + sets * 4* priceForEgg + sets * 0.2m*priceForBerry;

            if (total <= money)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {total-money:f2}lv more.");
            }
           

        }
    }
}
