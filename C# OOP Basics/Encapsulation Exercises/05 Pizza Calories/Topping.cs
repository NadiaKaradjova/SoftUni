using System;

namespace PizzaCalories
{
    internal class Topping
    {
        private string toppingType;
        private double weight;

        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        public string ToppingType
        {
            get { return this.toppingType; }

            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.toppingType = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public double GetCalories()
        {
            var calories = 2 * this.weight;
            switch (this.ToppingType.ToLower())
            {
                case "meat":
                    calories *= 1.2;
                    break;

                case "veggies":
                    calories *= 0.8;
                    break;

                case "cheese":
                    calories *= 1.1;
                    break;

                case "sauce":
                    calories *= 0.9;
                    break;
            }

            return calories;
        }
    }
}