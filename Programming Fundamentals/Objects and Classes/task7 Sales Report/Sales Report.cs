using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_Sales_Report
{
    public class task7_Sales_Report
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var totalSales = new Dictionary<string, SortedDictionary<string, double>>();
var sales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                
                var input = Console.ReadLine().Split();
                var currentSale = new Sale()
                {
                    Town = input[0],
                    Product = input[1],
                    Price = double.Parse(input[2]),
                    Quantity = double.Parse(input[3])
                };

                sales.Add(currentSale);
            }

            var result = new SortedDictionary<string, double>();

            foreach (var sale in sales)
            {
                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }
                result[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }

        }

        public class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public double Price { get; set; }
            public double Quantity { get; set; }

            public double Sales => Price * Quantity;
        }
    }
}
