using System;
using System.Globalization;

namespace Date_Modifier
{
    class DateModifier
    {
        public double difference;

        public double Diff(string firstDate, string secondDate)
        {
            var first = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var second = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            var days = Math.Abs((second - first).TotalDays);
            this.difference = days;
            return this.difference;
        }
    }
}
