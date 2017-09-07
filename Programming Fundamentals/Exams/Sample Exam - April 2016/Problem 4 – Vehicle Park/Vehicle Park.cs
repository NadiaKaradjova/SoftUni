using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Vehicle_Park
{
    public class Problem_4___Vehicle_Park
    {
        public static void Main()
        {
            var vehicles = Console.ReadLine().Split().ToList();

            var count = 0;

            var input = Console.ReadLine();

            while (input != "End of customers!")
            {
                var line = input.Split().ToArray();
                var vehicleLetter = line[0].First().ToString().ToLower();               
                var seats = int.Parse(line[2]);          

                var vehicleWanted = vehicleLetter + seats.ToString();                

                if (vehicles.Contains(vehicleWanted))
                {
                    var priceParameter1 = vehicleWanted.First();
                    var priceParameter2 = vehicleWanted.Skip(1).ToArray();
                    var digitString = "";
                    
                    foreach (var item in priceParameter2)
                    {
                        digitString += item;
                    }
                                        
                    var price = priceParameter1 * int.Parse(digitString);
                    Console.WriteLine($"Yes, sold for {price}$");
                    count++;
                    int index = vehicles.IndexOf(vehicleWanted);
                    vehicles.RemoveAt(index); 
                }
                else
                {
                    Console.WriteLine("No");
                }                

                input = Console.ReadLine();
            }

            Console.WriteLine($"Vehicles left: {string.Join(", ", vehicles)}");
            Console.WriteLine($"Vehicles sold: {count}");
        }
    }
}
