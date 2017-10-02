using System;
using System.Collections.Generic;
using System.Linq;


namespace _02_Cubic_s_Rube
{
    public class _02_Cubic_s_Rube
    {
        public static void Main()
        {
            var dimentions = int.Parse(Console.ReadLine());

            var totalCellNumbers = Math.Pow(dimentions, 3.0);

            var input = "";           

            var cells = new Dictionary<string, long>();

            while ((input = Console.ReadLine()) != "Analyze")
            {
                var parameters = input.Split().Select(long.Parse).ToArray();              

                
                if (parameters[0] >= 0 && parameters[0] < dimentions && parameters[1] >= 0 && parameters[1] < dimentions 
                    && parameters[2] >= 0 && parameters[2] < dimentions && parameters[3] !=0)
                {
                    var cell = input.Substring(0, 5);
                    if (!cells.ContainsKey(cell))
                    {
                        cells.Add(cell, parameters[3]);
                    }                    
                }
            }

            Console.WriteLine(cells.Values.Sum());
            Console.WriteLine(totalCellNumbers - cells.Count);
        }
    }
}
