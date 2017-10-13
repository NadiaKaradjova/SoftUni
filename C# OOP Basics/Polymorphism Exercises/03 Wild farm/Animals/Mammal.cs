namespace WildFarm.Animals
{
    public abstract class Mammal : Animal
    {
        protected string LivingRegion { get; set; }

        protected Mammal(string animalType, string animalName, double animalWeight, string livingRegion)
            : base(animalType, animalName, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }
    }
}