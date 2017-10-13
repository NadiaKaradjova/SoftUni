
using WildFarm.Animals;

namespace WildFarm.Factories
{
    public class AnimalFactory
    {

        public static Animal GetAnimal(string[] animalInfo)
        {
            switch (animalInfo[0]) 
            {
                case "Cat":
                    return new Cat(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]),
                        animalInfo[3], animalInfo[4]);
                case "Mouse":
                    return new Mouse(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]),
                        animalInfo[3]);
                case "Tiger":
                    return new Tiger(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]),
                        animalInfo[3]);
                case "Zebra":
                    return new Zebra(animalInfo[0], animalInfo[1], double.Parse(animalInfo[2]),
                        animalInfo[3]);
                    default: return null; 
            }
        }
        
    }
}
