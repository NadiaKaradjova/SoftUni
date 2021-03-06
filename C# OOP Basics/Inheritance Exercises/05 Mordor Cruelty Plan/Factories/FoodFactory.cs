﻿namespace MordorCrueltyPlan.Factories
{
   using Models;
   using Models.Foods;

    public class FoodFactory
    {    

        public Food GetFood(string foodType)
        {
            switch (foodType.ToLower())
            {
                case "cram": return new Cram();                    
                case "apple": return new Apple();
                case "honeycake": return new HoneyCake();
                case "lembas": return new Lembas();
                case "melon": return new Melon();
                case "mushrooms": return new Mushrooms();
                default: return new Junk();
            }
        }
    }
}
