using System;
using System.Collections.Generic;
using System.Globalization;
namespace Date_Modifier
{
    public class Program
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            
            var secondDate = Console.ReadLine();

            var days = new DateModifier();

            Console.WriteLine(days.Diff(firstDate, secondDate));
        }
    }
}
