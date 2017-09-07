using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_4_Roli___The_Coder
{
    public class Problem_4_Roli___The_Coder
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<int, Event>();

            while (input != "Time for Code")
            {
                var pattren = new Regex(@"(\d+)\s+#([\w\d]+)(\s+(?:@\w+\s*)+)?");
                var validData = pattren.Match(input);

                if (validData.Success)
                {
                    var line = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var id = int.Parse(line[0]);
                    var nameEvent = line[1].TrimStart('#');
                    var participant = line.Skip(2).ToList();

                    var currentEvent = new Event() { EventName = nameEvent, Participants = participant };

                    if (!result.ContainsKey(id))
                    {
                        result[id] = currentEvent;
                    }

                    if (result[id].EventName == nameEvent)
                    {
                        result[id].Participants.AddRange(participant);
                        result[id].Participants = result[id].Participants.Distinct().ToList();
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in result.OrderByDescending(x => x.Value.Participants.Count).ThenBy(a => a.Value.EventName))
            {
                var details = item.Value;
                Console.WriteLine($"{details.EventName} - {details.Participants.Count}");

                foreach (var people in details.Participants.OrderBy(y => y))
                {
                    Console.WriteLine(people);
                }
            } 
        }
    }
    public class Event
    {
        public string EventName { get; set; }
        public List<string> Participants { get; set; }
    }

}
