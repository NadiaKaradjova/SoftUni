using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03_Cubic_s_Messages
{
    public class _03_Cubic_s_Messages
    {
        public static void Main()
        {   
            var input = "";
            while ((input = Console.ReadLine()) != "Over!")
            {
                var n = int.Parse(Console.ReadLine());                
                var escapedValidPAttern = new Regex($@"^(\d+)([A-Za-z]{{{n}}})([^A-Za-z]*)$");
               
                var match = escapedValidPAttern.Match(input);
                if (match.Success)
                {
                    var message = match.Groups[2].Value;
                    var verificationCode = Decoder(match.Groups[1].Value, match.Groups[3].Value, message);

                    Console.WriteLine($"{message} == {verificationCode}");
                }
            }
            
        }

        public static string Decoder(string first, string second, string message)
        {
            var inputString = first;
            var sb = new StringBuilder();
            var digitPattern = new Regex(@"\d");
            var secondPartMatches = digitPattern.Matches(second);

            foreach (Match match in secondPartMatches)
            {
                inputString += match.Value;
            }

            foreach (var item in inputString)
            {
                var digit = item - '0';
                if (digit >= 0 && digit < message.Length)
                {
                    sb.Append(message[digit]);
                }
                else
                {
                    sb.Append(" ");
                }
            }
           
            return sb.ToString(); 
        }
    }
}
