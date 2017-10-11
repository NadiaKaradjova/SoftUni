namespace MordorCrueltyPlan
{
    using Factories;
    using Models;
    using System;

    public class Mordor_Cruelty_Plan
    {
        public static void Main()
        {
            var foodFactory = new FoodFactory();
            var moodFactory = new MoodFactory();

            var inputFood = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var gandalf = new Gandalf();

            foreach (var food in inputFood)
            {
                gandalf.Eat(foodFactory.GetFood(food));
            }

            var hapiness = gandalf.GetHappinessPoints();
            var currentMood = moodFactory.GetMood(hapiness);

            Console.WriteLine(hapiness);
            Console.WriteLine(currentMood);
        }
    }
}