namespace WildFarm.Animals
{
    public class Cat : Felime
    {
        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed)
            : base(animalType, animalName, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        private string Breed { get; set; }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.Breed}, {AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}