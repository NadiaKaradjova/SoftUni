using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Command_Interpreter
{
    public class _2_Command_Interpreter
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var commandLine = Console.ReadLine();
            var line = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var result = new int[0];

            while (commandLine != "end")
            {
                
                var command = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var action = command[0];

                if (action == "reverse" || action == "sort")
                {
                    var index = int.Parse(command[2]);
                    var count = int.Parse(command[4]);

                    if (index < 0 || index >= line.Length || count < 0 || count+index - 1 >= line.Length)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        commandLine = Console.ReadLine();
                        continue;
                    }

                    if (action == "reverse")
                    {
                        line = Reverse(line, index, count);
                    }

                    else if (action == "sort")
                    {
                        line = Sort(line, index, count);
                    }

                }

                else if (action == "rollLeft" || action == "rollRight")
                {
                    var count = int.Parse(command[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        commandLine = Console.ReadLine();
                        continue;
                    }

                    if (action == "rollLeft")
                    {
                        line = RollLeft(line, count);
                    }
                    else if (action == "rollRight")
                    {
                        line = rollRight(line, count);
                    }
                }

                commandLine = Console.ReadLine();
            }
           
            Console.WriteLine("["+(string.Join(", ", line))+"]");
        }

        private static string[] rollRight(string[] line, int count)
        {
            count %= line.Length;

            var line1 = line.ToList();

            for (int i = 0; i < count; i++)
            {
                var lastElement = line1.Last();
                var newList = line1.Take(line1.Count-1).ToList();
                newList.Insert(0, lastElement);
                line1 = newList;
            }

            return line1.ToArray();
        }

        private static string[] RollLeft(string[] line, int count)
        {
            count %= line.Length;

            var line1 = line.ToList();

            for (int i = 0; i < count; i++)
            {
                var firstElement = line1.First();
                var newList = line1.Skip(1).ToList();
                newList.Add(firstElement);
                line1 = newList;
            }

            return line1.ToArray();
        }

        private static string[] Sort(string[] line, int index, int count)
        {
            var line1 = line.ToList();            
            line1.Sort(index, count, StringComparer.InvariantCulture);
            return line1.ToArray();
        }

        public static string[] Reverse(string [] line, int index, int count)
        {
            
            var line1 = line.ToList();
            line1.Reverse(index, count);
            return line1.ToArray();
            
        }
    }
}
