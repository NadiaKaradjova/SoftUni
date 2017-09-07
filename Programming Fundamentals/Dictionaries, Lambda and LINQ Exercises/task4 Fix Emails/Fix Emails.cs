using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_A_Miner_Task
{
    public class task3_A_Miner_Task
    {
        public static void Main()
        {
            var emailsBook = new Dictionary<string, string>();

            while (true)
            {
                var name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                var email = Console.ReadLine();
                emailsBook[name] = email;                
            }
                            
            var finalEmailBook = emailsBook.Where(a => !a.Value.ToLower().EndsWith("uk") && !a.Value.ToLower().EndsWith("us"))
                .ToDictionary(p => p.Key, p => p.Value);
                
            foreach (var item in finalEmailBook)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
