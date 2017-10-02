using System;
using System.Collections.Generic;

namespace _01_Cubic_Artillery
{
    public class _01_Cubic_Artillery
    {
        public static void Main()
        {
            var maxCapacity = int.Parse(Console.ReadLine());

            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();
            var leftCapacity = maxCapacity;

            var input = Console.ReadLine();

            while(input != "Bunker Revision")
            {
                var line = input.Split();
                for (int i = 0; i < line.Length; i++)
                {
                    int weapon;
                    var isDigit = int.TryParse(line[i], out weapon);
                    if (!isDigit)
                    {
                        bunkers.Enqueue(line[i]);                        
                    }
                    else
                    {
                        var isSaved = false;
                        while (bunkers.Count > 1)
                        {
                            if (leftCapacity >= weapon)
                            {
                                weapons.Enqueue(weapon);
                                leftCapacity -= weapon;
                                isSaved = true;
                                break;
                            }


                            if (weapons.Count == 0)
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> {string.Join(", ", weapons)}");
                            }
                            
                            weapons.Clear();
                            leftCapacity = maxCapacity;
                        }

                        if (!isSaved)
                        {
                            if (maxCapacity >= weapon)
                            {
                                while (leftCapacity < weapon)
                                {
                                    leftCapacity += weapons.Dequeue();
                                }
                                weapons.Enqueue(weapon);
                                leftCapacity -= weapon;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
