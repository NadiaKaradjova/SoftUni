using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_Andrey_and_billiard
{
    public class task7_Andrey_and_billiard
    {
        public static void Main()
        {
            Dictionary<string, double> menu = ReadProducts();

            var input = Console.ReadLine();

            var allCustomer = new List<Customer>();


            while (input != "end of clients")
            {
                var line = input.Split('-', ',');
                var customerName = line[0];
                var productOrdered = line[1];
                double quantity = double.Parse(line[2]);

                if (menu.ContainsKey(productOrdered))
                {

                    Customer client = new Customer();
                    client.ShopList = new Dictionary<string, double>();
                    client.Name = customerName;
                    client.ShopList.Add(productOrdered, quantity);

                    if (allCustomer.Any(c => c.Name == customerName))
                    {
                        var existingCustomer = allCustomer.First(c => c.Name == customerName);

                        if (existingCustomer.ShopList.ContainsKey(productOrdered))
                        {
                            existingCustomer.ShopList[productOrdered] += quantity;
                        }
                        else
                        {
                            existingCustomer.ShopList[productOrdered] = quantity;
                        }
                    }
                    else
                    {
                        allCustomer.Add(client);
                    }
                }
                input = Console.ReadLine();
                
            }

            // make bill:
            foreach (var customer in allCustomer)
            {
                foreach (var item in customer.ShopList)
                {
                    foreach (var product in menu)
                    {
                        if (item.Key == product.Key)
                        {
                            customer.Bill += item.Value * product.Value;
                        }
                    }
                }
            }

            var ordered = allCustomer
                            .OrderBy(x => x.Name)
                            .ThenBy(x => x.Bill)
                            .ToList();
            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (var item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);

            }
            Console.WriteLine("Total bill: {0:F2}", allCustomer.Sum(c => c.Bill));
        }


        
        public static Dictionary<string,double> ReadProducts()
        {
            int n = int.Parse(Console.ReadLine());

           var listOfProducts = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                var nameProduct = input.First();
                var priceProduct = double.Parse(input.Last());

                if (!listOfProducts.ContainsKey(nameProduct))
                {
                    listOfProducts.Add(nameProduct, priceProduct);
                }
                listOfProducts[nameProduct] = priceProduct;
            }
            return listOfProducts;
        }

        public class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, double> ShopList { get; set; }
            public double Bill { get; set; }
        }
    }
}
