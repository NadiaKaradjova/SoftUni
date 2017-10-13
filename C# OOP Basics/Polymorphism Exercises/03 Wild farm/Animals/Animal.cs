using WildFarm.Models;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        protected Animal(string animalType, string animalName, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;
            this.FoodEaten = 0;
        }

        protected int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }

        protected string AnimalName
        {
            get { return this.animalName; }
            set { this.animalName = value; }
        }

        protected string AnimalType
        {
            get { return this.animalType; }
            set { this.animalType = value; }
        }

        protected double AnimalWeight
        {
            get { return this.animalWeight; }
            set { this.animalWeight = value; }
        }

        public abstract string MakeSound();

        public virtual void EatFood(Food food)
        {
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return "";
        }
    }
}