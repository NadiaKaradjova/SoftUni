using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Array_Manipulator
{
    public class _2_Array_Manipulator
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var line = input.Split().Select(int.Parse).ToList();

            var commandLineAll = Console.ReadLine();

            while (commandLineAll != "end")
            {
                
                var commandLine = commandLineAll.Split().ToArray();
                var command = commandLine[0];

                switch (command)
                {
                    case "exchange":
                        {
                            line = Exchange(line, int.Parse(commandLine[1]));                            
                        }
                        break;

                    case "max":
                        {
                            if (commandLine[1] == "even")
                            {
                                var maxEvenIndex = MaxEven(line);
                                if (maxEvenIndex < 0)
                                {
                                    Console.WriteLine("No matches");
                                }
                                else Console.WriteLine(maxEvenIndex);
                            }
                            else if (commandLine[1] == "odd")
                            {
                                var maxOddIndex = MaxOdd(line);
                                if (maxOddIndex < 0)
                                {
                                    Console.WriteLine("No matches");
                                }
                                else Console.WriteLine(maxOddIndex);
                            }
                        }
                        break;
                    case "min": 
                        {
                            if (commandLine[1] == "even")
                            {
                                var minEvenIndex = MinEven(line);
                                if (minEvenIndex < 0)
                                {
                                    Console.WriteLine("No matches");
                                }
                                else Console.WriteLine(minEvenIndex);
                            }
                            else if (commandLine[1] == "odd")
                            {
                                var minOddIndex = MinOdd(line);
                                if (minOddIndex < 0)
                                {
                                    Console.WriteLine("No matches");
                                }
                                else Console.WriteLine(minOddIndex);
                            }
                        }
                        break;
                    case "first":
                        {
                            var count = int.Parse(commandLine[1]);
                            
                            if (commandLine[2] == "even")
                            {
                                FirstEven(line, count);
                                
                            }
                            else if (commandLine[2] == "odd")
                            {
                                FirstOdd(line, count);
                                
                            }
                        }
                        break;

                    case "last":
                        {
                            var count = int.Parse(commandLine[1]);
                            if (commandLine[2] == "even")
                            {
                                LastEven(line, count);

                            }
                            else if (commandLine[2] == "odd")
                            {
                                LastOdd(line, count);

                            }
                        }
                        break;
                    

                }

                commandLineAll = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", line) + "]");
        }

        private static void LastOdd(List<int> line, int count)
        {
            if (count > line.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                var newList = line.Where(x => x % 2 != 0).ToList();
                var finalList = newList.Skip(newList.Count - count).Take(count).ToList();
                Console.WriteLine("[" + string.Join(", ", finalList) + "]");
            }
        }

        private static void LastEven(List<int> line, int count)
        {
            if (count > line.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                var newList = line.Where(x => x % 2 == 0).ToList();
                var finalList = newList.Skip(newList.Count - count).Take(count).ToList();
                Console.WriteLine("[" + string.Join(", ", finalList) + "]");
            }
        }

        private static void FirstOdd(List<int> line, int count)
        {
            if (count > line.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                var newList = line.Where(x => x % 2 != 0).ToList();
                var finalList = newList.Take(count).ToList();
                Console.WriteLine("[" + string.Join(", ", finalList) + "]");
            }
        }

        private static void FirstEven(List<int> line, int count)
        {
            if (count > line.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                var newList = line.Where(x => x % 2 == 0).ToList();
                var finalList = newList.Take(count).ToList();
                Console.WriteLine("[" + string.Join(", ", finalList) + "]");
            }
        }

        private static int MinOdd(List<int> line)
        {
            var minOddIndex = -1;

            for (int i = 0; i < line.Count; i++)
            {
                if (line[i] % 2 == 0)
                {
                    continue;
                }
                else
                {
                    minOddIndex = i;

                    for (int j = 0; j < line.Count; j++)
                    {
                        if (line[j] % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (line[i] > line[j])
                            {
                                var currentIndex = j;
                                if (line[minOddIndex] > line[currentIndex])
                                {
                                    minOddIndex = currentIndex;
                                }
                            }

                        }
                    }
                }
            }

            return minOddIndex;
        }

        private static int MinEven(List<int> line)
        {
            var minEvenIndex = -1;

            for (int i = 0; i < line.Count; i++)
            {
                if (line[i] % 2 != 0)
                {
                    continue;
                }
                else
                {
                    minEvenIndex = i;

                    for (int j = 0; j < line.Count; j++)
                    {
                        if (line[j] % 2 != 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (line[i] > line[j])
                            {
                                var currentIndex = j;
                                if (line[minEvenIndex]> line[currentIndex])
                                {
                                    minEvenIndex = currentIndex;
                                }
                            }
                            
                        }
                    }
                }
            }

            return minEvenIndex;
        }

        private static int MaxOdd(List<int> line)
        {
            var maxOddIndex = -1;

            for (int i = 0; i < line.Count; i++)
            {
                if (line[i] % 2 == 0)
                {
                    continue;
                }
                else
                {
                    maxOddIndex = i;

                    for (int j = 0; j < line.Count; j++)
                    {
                        if (line[j] % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            
                            if (line[maxOddIndex] < line[j])
                            {
                                maxOddIndex = j;
                            }
                        }
                    }
                }
            }

            return maxOddIndex;
        }

        private static int MaxEven(List<int> line)
        {
            var maxEvenIndex = -1;

            for (int i = 0; i < line.Count; i++)
            {
                if (line[i]%2 !=0)
                {
                    continue;
                }
                else
                {
                    maxEvenIndex = i;

                    for (int j = 0; j < line.Count; j++)
                    {
                        if (line[j] % 2 != 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (line[maxEvenIndex] < line[j])
                            {
                                maxEvenIndex = j;
                            }
                        }
                    }
                }
            }

            return maxEvenIndex;
        }

        private static List<int> Exchange(List<int> line, int index)
        {
            if (index < 0 || index >= line.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                var firstPart = line.GetRange(0, index+1);
                var secondPart = line.Skip(firstPart.Count).ToList();                                
                secondPart.AddRange(firstPart);
                line = secondPart;                
            }

            return line;
        }
    }
}
