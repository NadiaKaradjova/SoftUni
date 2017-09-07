using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftUni_Coffee_Supplies
{
    public class _04_SoftUni_Coffee_Supplies
    {
        public static void Main()
        {
            var delimiters = Console.ReadLine().Split().ToArray();
            var firstD = delimiters[0];
            var secondD = delimiters[1];

            var result = new List<Coffee>();

            var input = Console.ReadLine();

            while (input != "end of info")
            {
                var current = new Coffee();

                if (input.Contains($"{firstD}"))
                {
                    var line = input.Split(new string[] { $"{firstD}" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var personName = line[0];
                    var coffeeType = line[1];


                    if (!result.Any(x => x.CoffeeType == coffeeType))
                    {
                        current.CoffeeType = coffeeType;
                        current.CoffeeQuality = 0;
                        current.Person = new List<string>();
                        current.Person.Add(personName);
                        result.Add(current);
                    }
                    else
                    {
                        current = result.First(x => x.CoffeeType == coffeeType);
                        if (!current.Person.Contains(personName))
                        {
                            current.Person.Add(personName);
                        }
                    }
                }

                else if (input.Contains($"{secondD}"))
                {
                    var line = input.Split(new string[] { $"{secondD}" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var quantity = int.Parse(line[1]);
                    var coffeType = line[0];

                    if (result.Any(x => x.CoffeeType == coffeType))
                    {
                        current = result.First(x => x.CoffeeType == coffeType);
                        current.CoffeeQuality += quantity;
                    }
                    else
                    {
                        current.CoffeeType = coffeType;
                        current.CoffeeQuality = quantity;
                        current.Person = new List<string>();
                        result.Add(current);
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            foreach (var item in result.Where(x => x.CoffeeQuality <= 0))
            {
                Console.WriteLine($"Out of {item.CoffeeType}");
            }

            while (input != "end of week")
            {

                var line = input.Split().ToArray();
                var personName = line[0];
                var drunkCoffee = int.Parse(line[1]);
                
                var current = result.First(x => x.Person.Contains(personName));
                current.CoffeeQuality -= drunkCoffee;

                if (current.CoffeeQuality <= 0)
                {
                    Console.WriteLine($"Out of {current.CoffeeType}");
                }

                input = Console.ReadLine();
            }

            
            Console.WriteLine("Coffee Left:");
            foreach (var item in result.Where(x => x.CoffeeQuality > 0).OrderByDescending(y => y.CoffeeQuality))
            {
                Console.WriteLine($"{item.CoffeeType} {item.CoffeeQuality}");
            }

            Console.WriteLine("For:");
            foreach (var item in result.Where(x => x.CoffeeQuality > 0).OrderBy(y => y.CoffeeType))
            {
                var persons = item.Person;
                foreach (var person in persons.OrderByDescending(y => y))
                {
                    Console.WriteLine($"{person} {item.CoffeeType}");
                }
            }
        }
    }

    public class Coffee
    {
        public string CoffeeType { get; set; }
        public int CoffeeQuality { get; set; }
        public List<string> Person { get; set; }
    }
}
