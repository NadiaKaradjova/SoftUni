using System;
using System.Globalization;


namespace _1_Coffee_Orders
{
    public class _1_Coffee_Orders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0.0m;

            for (int i = 0; i < n; i++)
            {
                var price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var count = int.Parse(Console.ReadLine());

                var dayInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                                
                var total = dayInMonth * price * count;
                sum += total;
                Console.WriteLine($"The price for the coffee is: ${total:f2}");
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}
