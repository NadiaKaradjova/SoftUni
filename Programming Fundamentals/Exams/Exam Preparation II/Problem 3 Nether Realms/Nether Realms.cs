using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3_Nether_Realms
{
    public class Problem_3_Nether_Realms
    {
        public static void Main()
        {
            var deamonName = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var result = new SortedDictionary<string, List<double>>();

            foreach (var name in deamonName)
            {                                              
                var patern = new Regex(@"[^0-9\*\-\+\/\.]");
                var healthPattern = patern.Matches(name).Cast<Match>().Select(x => x.Value).ToArray();
                var newHealtPatern = string.Join("", healthPattern);
               
                var patern1 = new Regex(@"([-+]?(\d+\.)?\d+)");
                var damagePattern = patern1.Matches(name).Cast<Match>().Select(x => x.Value).ToArray();

                var patern2 = new Regex(@"[\*\/]");
                var aritmeticSymbols = patern2.Matches(name).Cast<Match>().Select(x => x.Value).ToArray();

                var listDaemon = new List<double>();

                var sumSymbols = 0;

                foreach (var symbol in newHealtPatern)
                {
                    sumSymbols += symbol;
                }

                listDaemon.Add(sumSymbols);

                var sumDamage = 0.0;

                foreach (var symbol in damagePattern)
                {
                    var digit = double.Parse(symbol);
                    sumDamage += digit;                    
                }

                foreach (var item in aritmeticSymbols)
                {
                    if (item == "*")
                    {
                        sumDamage *= 2;
                    }
                    else
                    {
                        sumDamage /= 2;
                    }
                }
                
                listDaemon.Add(sumDamage);
                result.Add(name, listDaemon);
            }
            
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");
            }
        
        }
    }
}
