using System;
using WildFarm.Animals;
using WildFarm.Factories;
using WildFarm.Models;

namespace WildFarm
{
    public class Wild_farm
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var animalInfo = inputLine.Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);

                var foodInfo = Console.ReadLine()
                    .Split(new char[] {' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);
                Animal animal = AnimalFactory.GetAnimal(animalInfo);
                Food food = FoodFactory.GetFood(foodInfo);
                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.EatFood(food);

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(animal);


                inputLine = Console.ReadLine();
            }
        }


    }
}
