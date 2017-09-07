using System;
using System.Globalization;

namespace task1_Day_of_Week
{
    public class task1_Day_of_Week
    {
        public static void Main()
        {
            var inputDate = Console.ReadLine();
            var date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
