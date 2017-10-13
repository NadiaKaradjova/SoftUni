using WildFarm.Models;

namespace WildFarm.Factories
{
    public class FoodFactory
    {
        public static Food GetFood(string[] foodInfo)
        {
            var foodType = foodInfo[0];
            var foodQuantity = int.Parse(foodInfo[1]);

            if (foodType == "Meat")
            {
                return new Meat(foodQuantity);
            }

            return new Vegetable(foodQuantity);
        }
    }
}