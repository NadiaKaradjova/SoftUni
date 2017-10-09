using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Shopping_Spree
    {
        public static void Main()
        {
            var allPersons = new List<Person>();
            var allProducts = new List<Product>();

            var persons = Console.ReadLine().Split(new[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var products = Console.ReadLine().Split(new[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    var personData = persons[i].Split('=');
                    var nameOfPerson = personData[0];
                    var moneyOfPerson = double.Parse(personData[1]);

                    var currentPerson = new Person(nameOfPerson, moneyOfPerson);
                    allPersons.Add(currentPerson);
                }

                for (int i = 0; i < products.Length; i++)
                {
                    var productData = products[i].Split('=');
                    var nameOfProduct = productData[0];
                    var productPrice = double.Parse(productData[1]);

                    var currentProduct = new Product(nameOfProduct, productPrice);
                    allProducts.Add(currentProduct);
                }

                var command = Console.ReadLine();

                while (command != "END")
                {
                    var line = command.Split();
                    var nameOfPerson = line[0];
                    var nameOfProduct = line[1];

                    var current = allPersons.FirstOrDefault(p => p.Name == nameOfPerson);
                    try
                    {
                        current.AddProduct(allProducts.FirstOrDefault(pr => pr.Name == nameOfProduct));
                        Console.WriteLine($"{nameOfPerson} bought {nameOfProduct}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    command = Console.ReadLine();
                }

                foreach (var person in allPersons)
                {
                    var boughtProducts = person.Products;
                    var result = boughtProducts.Any() ? string.Join(", ", boughtProducts.Select(pr => pr.Name).ToList()) : "Nothing bought";

                    Console.WriteLine($"{person.Name} - {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}