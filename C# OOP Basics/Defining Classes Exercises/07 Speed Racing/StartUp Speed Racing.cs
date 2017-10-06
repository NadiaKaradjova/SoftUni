using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Speed_Racing
    {
        public static void Main()
        {
            var allCars = new List<Car>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var model = input[0];
                var fuelAmount = double.Parse(input[1]);
                var fuelConsumation = double.Parse(input[2]);

                var currentCar = new Car(model, fuelAmount, fuelConsumation);
                allCars.Add(currentCar);
            }

            var commandLine = Console.ReadLine();

            while (commandLine != "End")
            {
                var commArg = commandLine.Split();
                var currentModel = commArg[1];
                var distance = double.Parse(commArg[2]);

                var currentCar = allCars.Where(x => x.Model == currentModel).First();
                currentCar.Drive(currentModel, distance);

                commandLine = Console.ReadLine();
            }

            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.AmountOfKm}");
            }
        }
    }
}
