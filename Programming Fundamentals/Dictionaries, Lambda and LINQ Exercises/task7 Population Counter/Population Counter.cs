using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_Population_Counter
{
    public class task7_Population_Counter
    {
        public static void Main()
        {
            var polulationCountry = new Dictionary<string, Dictionary<string, long>>();

            var line = Console.ReadLine();

            while (line != "report")
            {
                var inputItems = line.Split('|').ToArray();
                var city = inputItems[0];
                var country = inputItems[1];
                long citizens = long.Parse(inputItems[2]);


                if (!polulationCountry.ContainsKey(country))
                {
                    polulationCountry[country] = new Dictionary<string, long>();
                }

                var populationCity = polulationCountry[country];

                if (!populationCity.ContainsKey(city))
                {
                    populationCity[city] = citizens;
                }


                line = Console.ReadLine();
            }



            foreach (var newCountry in polulationCountry.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var countryPeople = newCountry.Value.OrderByDescending(p => p.Value).ToDictionary(p => p.Key, p => p.Value);

                Console.WriteLine($"{newCountry.Key} (total population: {countryPeople.Values.Sum()})");

                foreach (var city in countryPeople)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }

            }


        }
            
        
    }
}
