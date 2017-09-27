using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Filter_by_Age
{
    public class _05_Filter_by_Age
    {
        public static void Main()
        {
            var result = new Dictionary<string, int>();
            Func<string, int> parser = text => int.Parse(text);

            var n = parser(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var human = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                result.Add(human[0], parser(human[1]));                                 
            }

            var compareWord = Console.ReadLine();
            var age = parser(Console.ReadLine());
            var printCommand = Console.ReadLine();

            if (compareWord == "older")
            {
                result = result.Where(a => a.Value >= age).ToDictionary(k => k.Key, v => v.Value);
            }
            else
            {
                result = result.Where(a => a.Value < age).ToDictionary(k => k.Key, v => v.Value);
            }

            foreach (var item in result)
            {
                switch (printCommand)
                {
                    case "age": Console.WriteLine(item.Value);
                        break;
                    case "name": Console.WriteLine(item.Key);
                        break;
                    default: Console.WriteLine($"{item.Key} - {item.Value}");
                        break;
                }
            }            
        }
    }
}
