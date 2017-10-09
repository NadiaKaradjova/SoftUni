using System;

namespace PizzaCalories
{
    internal class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value.ToLower();
            }
        }

        public string BakingTechnique
        {
            get { return this.bakingTechnique; }

            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value.ToLower();
            }
        }

        public double Weight
        {
            get { return this.weight; }

            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double GetCalories()
        {
            var calories = 2 * this.Weight;
            switch (this.FlourType)
            {
                case "white":
                    calories *= 1.5;
                    break;

                case "wholegrain":
                    calories *= 1;
                    break;
            }
            switch (this.BakingTechnique)
            {
                case "crispy":
                    calories *= 0.9;
                    break;

                case "chewy":
                    calories *= 1.1;
                    break;

                case "homemade":
                    calories *= 1;
                    break;
            }
            return calories;
        }
    }
}