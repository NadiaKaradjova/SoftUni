using System;

namespace ShoppingSpree
{
    internal class Product
    {
        private string name;
        private double cost;

        public Product(string product, double cost)
        {
            this.Name = product;
            this.Cost = cost;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
                }
                this.name = value;
            }
        }

        public double Cost
        {
            get { return this.cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }
                this.cost = value;
            }
        }
    }
}