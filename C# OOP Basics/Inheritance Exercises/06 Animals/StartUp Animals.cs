using Animals.Exeptions;
using Animals.Models;
using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            var animalType = Console.ReadLine();

            while (animalType != "Beast!")
            {
                try
                {
                    var animalParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = animalParams[0];
                    var gender = animalParams[2];

                    int age;

                    if (!int.TryParse(animalParams[1], out age))
                    {
                        throw new InvalidInputExeptions();
                    }

                    switch (animalType)
                    {
                        case "Cat":
                            var cat = new Cat(name, age, gender);
                            Console.WriteLine(cat);
                            break;

                        case "Kitten":
                            var kitten = new Kitten(name, age);
                            Console.WriteLine(kitten);
                            break;

                        case "Tomcat":
                            var tomcat = new Tomcat(name, age);
                            Console.WriteLine(tomcat);
                            break;

                        case "Frog":
                            var frog = new Frog(name, age, gender);
                            Console.WriteLine(frog);
                            break;

                        case "Dog":
                            var dog = new Dog(name, age, gender);
                            Console.WriteLine(dog);
                            break;
                            default: throw new InvalidInputExeptions();
                    }
                }
                catch (InvalidInputExeptions e)
                {
                    Console.WriteLine(e.Message);
                }

                animalType = Console.ReadLine();
            }
        }
    }
}