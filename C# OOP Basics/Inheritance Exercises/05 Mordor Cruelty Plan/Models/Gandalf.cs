namespace MordorCrueltyPlan.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Gandalf
    {
        private List<Food> foodEathen;

        public Gandalf()
        {
            this.foodEathen = new List<Food>();
        }

        public void Eat(Food food)
        {
            this.foodEathen.Add(food);
        }

        public int GetHappinessPoints()
        {
            return this.foodEathen.Sum(f => f.GetHappinessPoints());
        }
    }
}