using System;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private double weekSalary;
        private double hoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double hoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.HoursPerDay = hoursPerDay;
        }

        public double HoursPerDay
        {
            get { return this.hoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.hoursPerDay = value;
            }
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.HoursPerDay:f2}")
                .AppendLine($"Salary per hour: {this.WeekSalary/(this.HoursPerDay*5):f2}");
            return sb.ToString();
        }
    }
}