using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task1_Extract_emails
{
    public class task1_Extract_emails
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"([\w-.]+)\@[\w-]+(\.[a-zA-Z]+)+");

            var result = regex.Matches(text);

            foreach (Match item in result)
            {
                var email = item.ToString();
                if (!(email.StartsWith(".") || email.StartsWith("_") || email.StartsWith("-") || 
                    email.EndsWith(".") || email.EndsWith("_") || email.EndsWith("-")))
                {
                    Console.WriteLine(email);
                }
                
            }
        }
    }
}
