using System;
using ExplicitInterfaces.Interfaces;
using ExplicitInterfaces.Models;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "End")
            {
                var line = input.Split();
                var name = line[0];
                var country = line[1];
                var age = int.Parse(line[2]);
                
                Citizen citizen = new Citizen(name, age, country);
                IPerson person = citizen;
                IResident resident = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());

                input = Console.ReadLine();
            }
        }
    }
}
