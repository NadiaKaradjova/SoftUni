using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10_Сръбско_Unleashed
{
    public class task10_Сръбско_Unleashed
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var placeConcert = new Dictionary<string, Dictionary<string, long>>();
          
            while (input.ToLower() != "end")
            {
                var line = input.Split(' ').ToList();
                var len = line.Count;
                
                if (len >= 4)
                {
                    int ticketCount = 0;
                    int ticket = 0;

                    if (int.TryParse(line.Last(), out ticket) && int.TryParse(line[line.Count - 2], out ticketCount))
                    {
                        var index = line.FindIndex(x => x.StartsWith("@"));

                        if (index > 0)                        
                        {
                            ticketCount = int.Parse(line.Last());
                            line.RemoveAt(line.Count - 1);
                            ticketCount = int.Parse(line.Last());
                            line.RemoveAt(line.Count - 1);

                            var placeLine = line.GetRange(index, line.Count - index).ToList();
                            var singerLine = line.GetRange(0, line.Count - placeLine.Count);

                            var place = string.Join(" ", placeLine);
                            place = place.Remove(0, 1);

                            var singer = string.Join(" ", singerLine);

                            if (!placeConcert.ContainsKey(place))
                            {
                                placeConcert[place] = new Dictionary<string, long>();
                            }

                            var singerMoney = placeConcert[place];

                            if (!singerMoney.ContainsKey(singer))
                            {
                                singerMoney.Add(singer, 0);

                            }
                            singerMoney[singer] += (long)ticket * ticketCount;
                        }                        
                    }
                }
                                
                input = Console.ReadLine();
            }

            foreach (var item in placeConcert)
            {
                Console.WriteLine($"{item.Key}");
                var concerts = item.Value;

                foreach (var singer in concerts.OrderByDescending(x =>x.Value))
                {
                    
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                } 
            }
        }
    }
}
