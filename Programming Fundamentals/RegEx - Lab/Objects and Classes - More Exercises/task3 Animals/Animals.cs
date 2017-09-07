using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_Animals
{
    public class task3_Animals
    {
        public static void Main()
        {
            var dogs = new List<Dog>();
            var cats = new List<Cat>();
            var snakes = new List<Snake>();

            var input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                var line = input.Split();

                if (line.Length == 4)
                {
                    var newClass = line[0];
                    var name = line[1];
                    var param = line.Skip(2).Select(int.Parse).ToList();
                    if (newClass == "Dog")
                    {
                        var newDog = new Dog();
                        newDog.Name = name;
                        newDog.Age = int.Parse(line[2]);
                        newDog.NumberOfLegs = int.Parse(line[3]);

                        dogs.Add(newDog);
                    }
                    else if (newClass == "Cat")
                    {
                        var newCat = new Cat();
                        newCat.Name = name;
                        newCat.Age = int.Parse(line[2]);
                        newCat.IntelligenceQuotient = int.Parse(line[3]);

                        cats.Add(newCat);
                    }
                    else if (newClass == "Snake")
                    {
                        var newSnake = new Snake();
                        newSnake.Name = name;
                        newSnake.Age = int.Parse(line[2]);
                        newSnake.CrueltyCoefficient = int.Parse(line[3]);

                        snakes.Add(newSnake);
                    }

                }

                if (line.Length == 2)
                {
                    var name = line[1];
                    if (dogs.Any(c => c.Name == name))
                    {
                        Dog.ProduceSound();
                    }
                    else if (cats.Any(c => c.Name == name))
                    {
                        Cat.ProduceSound();
                    }
                    else if (snakes.Any(c => c.Name == name))
                    {
                        Snake.ProduceSound();
                    }


                }
                
                input = Console.ReadLine();
            }

            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }
            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }

        }

        public class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int NumberOfLegs { get; set; }

            public static void ProduceSound()
            {
                Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
            }
        }

        public class Cat
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int IntelligenceQuotient { get; set; }

            public static void ProduceSound()
            {
                Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
            }
        }

        public class Snake
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int CrueltyCoefficient { get; set; }

            public static void ProduceSound()
            {
                Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
            }
        }
    }
}
