using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_Websites
{
    public class task4_Websites
    {
        public static void Main()
        {
            //softuni | bg | user,course,homework
            var webSite = new List<Website>();

            var input = Console.ReadLine();

            while(input != "end")
            {
                var line = input.Split(new char[] { '|', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var host = line[0];
                var domain = line[1];
                var newWebSite = new Website() { Host = host, Domain = domain };

                if (line.Count > 2)
                {
                    var queries = line[2].Split(',').ToList();              
                    newWebSite.Queries = new List<string>();
                    newWebSite.Queries = queries;
                }
                
                webSite.Add(newWebSite);

                input = Console.ReadLine();
            }

            foreach (var item in webSite)
            {
                Console.Write($"https://www.{item.Host}.{item.Domain}");

                if (item.Queries != null)
                {
                    Console.Write("/query?=");
                    for (int i = 0; i < item.Queries.Count; i++)
                    {
                       
                        if (i == item.Queries.Count-1)
                        {
                            Console.WriteLine($"[{item.Queries[i]}]");
                        }
                        else  Console.Write($"[{item.Queries[i]}]&");
                    }

                }
                else Console.WriteLine();
                
            }
        }

        public class Website
        {
            public string Host { get; set; }
            public string Domain { get; set; }
            public List<string> Queries { get; set; }
        }
    }
}
