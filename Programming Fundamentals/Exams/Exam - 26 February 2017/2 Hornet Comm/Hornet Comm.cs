using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_Hornet_Comm
{
    public class _2_Hornet_Comm
    {
        public static void Main()
        {
            var messageList = new List<string>();
            var broadcastList = new List<string>();

            var input = Console.ReadLine();

            var messagePattern = new Regex(@"(\d+)\s<->\s([A-Za-z0-9]+$)");
            var broadcastPattern = new Regex(@"^([\D]+)\s<->\s([A-Za-z\d]+)$");

            while (input != "Hornet is Green")
            {
                var message = messagePattern.Match(input);

                if (message.Success)
                {
                    var first = message.Groups[1].Value;
                    var finalFirst = string.Join("", first.Reverse());
                    var second = message.Groups[2].Value;
                    var final = finalFirst + " -> " + second;
                    messageList.Add(final);
                }

                var broadcast = broadcastPattern.Match(input);
                if (broadcast.Success)
                {
                    var first = broadcast.Groups[2].Value;
                    var finalFirst = "";

                    foreach (var item in first)
                    {
                        if (char.IsUpper(item))
                        {
                            var temp = char.ToLower(item);
                            finalFirst += temp;
                        }
                        else if (char.IsLower(item))
                        {
                            var temp = char.ToUpper(item);
                            finalFirst += temp;
                        }
                        else if (!char.IsLetter(item))
                        {
                            finalFirst += item;
                        }
                    }

                    var second = broadcast.Groups[1];
                    var final = finalFirst + " -> " + second;
                    broadcastList.Add(final);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcastList.Count > 0)
            {
                foreach (var item in broadcastList)
                {
                    Console.WriteLine(item);
                }
            }
            else Console.WriteLine("None");


            Console.WriteLine("Messages:");
            if (messageList.Count > 0)
            {
                foreach (var item in messageList)
                {
                    Console.WriteLine(item);
                }
            }
            else Console.WriteLine("None");
        }
    }
}
