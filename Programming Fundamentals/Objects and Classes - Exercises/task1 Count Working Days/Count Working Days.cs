using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace task1_Count_Working_Days
{
    public class task1_Count_Working_Days
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var startDate = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            input = Console.ReadLine();
            var endDate = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var officialHolidays = new []
            {
                    "01-01",
                    "03-03", 
                    "01-05",
                    "06-05",
                    "24-05",
                    "06-09",
                    "22-09",
                    "01-11",
                    "24-12",
                    "25-12",
                    "26-12"
            }.Select(a => DateTime.ParseExact(a, "dd-MM", CultureInfo.InvariantCulture));
                
            int countDay = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday 
                    && !(officialHolidays.Any(d => d.Day == currentDate.Day && d.Month == currentDate.Month)))
                {
                    countDay++;
                }
            }

            Console.WriteLine(countDay);
        }
    }    
}
