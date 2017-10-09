using System;

namespace PizzaCalories
{
    public class Pizza_Calories
    {
        public static void Main()
        {
            string inputLine;

            while ((inputLine = Console.ReadLine()) != "END")
            {
                var tokens = inputLine.Split(' ');

                try
                {
                    switch (tokens[0])
                    {
                        case "Dough":
                            var dough = new Dough(tokens[1], tokens[2], double.Parse(tokens[3]));
                            Console.WriteLine($"{dough.GetCalories():f2}");
                            break;

                        case "Topping":
                            var topping = new Topping(tokens[1], double.Parse(tokens[2]));
                            Console.WriteLine($"{topping.GetCalories():f2}");
                            break;

                        case "Pizza":
                            MakePizza(tokens);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }

        private static void MakePizza(string[] param)
        {
            var pizzaName = param[1];
            var numberOfToppings = int.Parse(param[2]);
            var pizza = new Pizza(pizzaName, numberOfToppings);
            var doughParam = Console.ReadLine().Split();
            var dough = new Dough(doughParam[1], doughParam[2], double.Parse(doughParam[3]));
            pizza.Dough = dough;

            for (var i = 0; i < numberOfToppings; i++)
            {
                var topInfo = Console.ReadLine().Split(' ');
                var topping = new Topping(topInfo[1], double.Parse(topInfo[2]));
                pizza.AddTopping(topping);
            }

            Console.WriteLine($"{pizza.Name} - {pizza.GetPizzaCallories():f2} Calories.");
        }
    }
}