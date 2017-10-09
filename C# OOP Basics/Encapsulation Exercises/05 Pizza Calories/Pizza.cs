using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    internal class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        private int numberOfTopping;

        public Pizza(string name, int numberOfTopping)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
            this.NumberOfTopping = numberOfTopping;
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public int NumberOfTopping
        {
            get
            {
                return this.numberOfTopping;
            }

            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException($"Number of toppings should be in range [0..10].");
                }
                this.numberOfTopping = value;
            }
        }

        internal Dough Dough
        {
            get
            {
                return this.dough;
            }

            set
            {
                this.dough = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public double GetPizzaCallories()
        {
            return this.Dough.GetCalories() + this.toppings.Sum(t => t.GetCalories());
        }
    }
}