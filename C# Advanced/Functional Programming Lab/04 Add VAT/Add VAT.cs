using System;
using System.Linq;

namespace _04_Add_VAT
{
    public class _04_Add_VAT
    {
        public static void Main()
        {
            Func<double, double> PriceWithVat = n => n * 1.2;

            var numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(PriceWithVat)
                .ToArray();

            foreach (var price in numbers)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
