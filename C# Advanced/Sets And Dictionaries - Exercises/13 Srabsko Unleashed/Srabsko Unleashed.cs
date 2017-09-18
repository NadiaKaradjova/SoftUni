using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _13_Srabsko_Unleashed
{
    public class _13_Srabsko_Unleashed
    {
        public static void Main()
        {
            var concertList = new Dictionary<string, Dictionary<string, int>>();
            var validString = new Regex(@"^([\w||\s]+)\s@([\w||\s]+)\s(\d+)\s(\d+)$");

            var input = Console.ReadLine();

            while (input != "End")
            {
                var line = validString.Match(input);

                if (line.Success)
                {
                    var singer = line.Groups[1].Value;
                    var place = line.Groups[2].Value;
                    var ticketsPrice = int.Parse(line.Groups[3].Value);
                    var ticketsCount = int.Parse(line.Groups[4].Value);

                    if (!concertList.ContainsKey(place))
                    {
                        concertList[place] = new Dictionary<string, int>();
                    }
                    var concert = concertList[place];
                    if (!concert.ContainsKey(singer))
                    {
                        concert[singer] = 0;
                    }
                    concert[singer] += ticketsCount*ticketsPrice;
                }

                input = Console.ReadLine();
            }

            foreach (var town in concertList)
            {
                Console.WriteLine(town.Key);
                var singerBenefits = town.Value;
                foreach (var singer in singerBenefits.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
