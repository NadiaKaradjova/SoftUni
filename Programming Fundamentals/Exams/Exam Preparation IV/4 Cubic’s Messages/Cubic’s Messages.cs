using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4_Cubic_s_Messages
{
    public class _4_Cubic_s_Messages
    {
        public static void Main()
        {
            var list = new Dictionary<string, string>();

            var message = Console.ReadLine();
            
            while (message != "Over!")
            {
                var n = int.Parse(Console.ReadLine());
                var pattern = new Regex($@"(^\d+)([A-Za-z]{{{n}}})([^A-Za-z]*$)");
                var encripted = pattern.Match(message);
                                
                if (encripted.Success)
                {
                    var before = encripted.Groups[1].Value.ToString();
                    var realMessage = encripted.Groups[2].Value.ToString();
                    var after = encripted.Groups[3].Value.ToString();

                    if (!list.ContainsKey(realMessage))
                    {
                        list[realMessage] = "";
                    }

                    var verificationCode = new StringBuilder();

                    foreach (var symbol in before)
                    {
                        var digit = symbol - '0';

                        if (digit > realMessage.Length - 1)
                        {
                            verificationCode.Append(" ");
                        }
                        else
                        {
                            var digitToAdd = realMessage[digit];
                            verificationCode.Append(digitToAdd);
                        }
                    }
                    
                    var onlyDigit = new Regex(@"\d");
                    var afterOnlyDigit = onlyDigit.Matches(after);

                    var listOfdigit = "";

                    foreach (Match item in afterOnlyDigit)
                    {
                        listOfdigit += item;
                    }
                    
                    if (listOfdigit.Length > 0)
                    {
                        foreach (var symbol in listOfdigit)
                        {
                            var digit = symbol - '0';

                            if (digit > realMessage.Length - 1)
                            {
                                verificationCode.Append(" ");
                            }
                            else
                            {
                                var digitToAdd = realMessage[digit];
                                verificationCode.Append(digitToAdd);
                            }
                        }
                    }

                    list[realMessage] = verificationCode.ToString();
                }

                message = Console.ReadLine();                
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key} == {item.Value}");
            }
        }
    }
}
