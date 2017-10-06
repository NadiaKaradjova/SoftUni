namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;   

    public class GoogleProgram
    {
        public static void Main()
        {
            var persons = new List<Person>();
            
            var input = Console.ReadLine();

            while (input != "End")
            {
                var line = input.Split();
                var personName = line[0];

                if (!persons.Any(x => x.Name == personName))
                {
                    var person = new Person(personName);
                    persons.Add(person);
                }

                var currentPerson = persons.First(x => x.Name == personName);
                
                switch (line[1])
                {
                    case "company":
                        var salaryToDigit = double.Parse(line.Last());
                        var salaryToString = $"{salaryToDigit:f2}";
                        line[4] = salaryToString;
                        currentPerson.Company = line.Skip(2).ToList();
                            break;
                    case "car": currentPerson.Car = line.Skip(2).ToList();
                        break;
                    case "parents":
                        var currentParent = new Parent(line[2], line[3]);
                        currentPerson.Parents.Add(currentParent);
                        break;
                    case "children":
                        var currentChildren = new Children(line[2], line[3]);
                        currentPerson.Children.Add(currentChildren);
                        break;
                    case "pokemon":
                        var currentPokemon = new Pokemon(line[2], line[3]);
                        currentPerson.Pokemons.Add(currentPokemon);
                        break;                        
                }
                
                input = Console.ReadLine();           

            }

            var nameForSearch = Console.ReadLine();

            var item = persons.First(x => x.Name == nameForSearch);
            
                Console.WriteLine(item.Name);
                Console.WriteLine("Company:");
                if (item.Company.Count > 0)
                {
                    Console.WriteLine(string.Join(" ", item.Company));
                }
                Console.WriteLine("Car:");
                if (item.Car.Count > 0)
                {
                    Console.WriteLine(string.Join(" ", item.Car));
                }
                Console.WriteLine("Pokemon:");
                foreach (var pokemon in item.Pokemons)
                {
                    Console.WriteLine($"{pokemon.PokemonName} {pokemon.PokemonType}");
                }
                Console.WriteLine("Parents:");
                foreach (var parent in item.Parents)
                {
                    Console.WriteLine($"{parent.ParentName} {parent.ParentBirthDay}");
                }
                Console.WriteLine("Children: ");
                foreach (var children in item.Children)
                {
                    Console.WriteLine($"{children.ChildrenName} {children.ChildrenBirthDay}");
                }            
        }
    }
}
