using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_4_Winning_Ticket
{
    public class Problem_4_Winning_Ticket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                var firstPart = ticket.Substring(0, 10);
                var secondPart = ticket.Substring(10, 10);

                var winningSymbols = new string[] { "@", "\\$", "#", "\\^" };
                var isWinTicket = false;

                foreach (var winningSymbol in winningSymbols)
                {
                    var pattern = new Regex($"{winningSymbol}{{6,}}");

                    var result = pattern.Match(firstPart);
                    
                    if (result.Success)
                    {
                        var result1 = pattern.Match(secondPart);
                        if (result1.Success)
                        {
                            isWinTicket = true;
                            if (result.Length == result1.Length)
                            {
                                if (result.Length < 10)
                                {
                                    Console.WriteLine($"ticket \"{ticket}\" - {result.Length}{winningSymbol.TrimStart('\\')}");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"ticket \"{ticket}\" - {result.Length}{winningSymbol.TrimStart('\\')} Jackpot!");
                                    break;
                                }
                            }
                            else if (result.Length != result1.Length)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(result.Length, result1.Length)}{winningSymbol.TrimStart('\\')}");
                                break;
                            }
                        }
                    }                     
                }

                if (!isWinTicket)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");                    
                }              

            }
        }
    }
}
