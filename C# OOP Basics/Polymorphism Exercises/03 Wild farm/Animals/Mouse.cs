﻿using System;
using WildFarm.Models;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string animalType, string animalName, double animalWeight, string livingRegion) 
            : base(animalType, animalName, animalWeight, livingRegion)
        {
        }
        public override void EatFood(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
            }
            base.EatFood(food);
        }

        public override string MakeSound()
        {
            return "SQUEEEAAAK!";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
