using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem_2_SoftUni_Karaoke
{
    public class Problem_2_SoftUni_Karaoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();
            var songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();

           var result = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();
        

            while (input != "dawn")
            {
                var line = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();

                var participant = line[0];
                var song = line[1];
                var award = line[2];

                
                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!result.ContainsKey(participant) )
                    {
                        result[participant] = new List<string>();
                    }

                    var awards = result[participant];

                    if (!awards.Contains(award))
                    {
                        awards.Add(award);
                    }  
                }
              
                input = Console.ReadLine();
            }

            if (!result.Any())
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in result.OrderByDescending(p => p.Value.Count).ThenBy(a => a.Key))
                {
                    var name = item.Key;
                    var awards = item.Value;

                    Console.WriteLine($"{name}: {awards.Count} awards");
                    foreach (var award in awards.OrderBy(p => p))
                    {
                        Console.WriteLine($"--{award}");
                    }                   
                }
            }
        }
    }
}
