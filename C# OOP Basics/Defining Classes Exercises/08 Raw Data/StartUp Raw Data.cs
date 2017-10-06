namespace RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Raw_Data
    {
        public static void Main()
        {
            var allCars = new List<Car>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {                
                var input = Console.ReadLine().Split();
                var model = input[0];
                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);
                var engine = new Engine(engineSpeed, enginePower);

                var cargoWeight = int.Parse(input[3]);
                var cargoType = input[4];
                var cargo = new Cargo(cargoWeight, cargoType);

                var tiresInput = input.Skip(5).ToArray();

                var tires = new Tire[4];
                var index = 0;
                for (int t = 0; t < 4*2; t+=2)
                {
                    var tire = new Tire(double.Parse(tiresInput[t]), int.Parse(tiresInput[t+1]));
                    tires[index] = tire;
                    index++;
                }
                
                var currentCar = new Car(model, engine, cargo, tires);
                allCars.Add(currentCar);
            }
            var command = Console.ReadLine();
            if (command == "fragile")
            {
                var resultByType = allCars.Where(x => x.Cargo.CargoType == command).ToList();
                var resultByTires = resultByType.Where(x => x.Tires.Any(y => y.TirePressure < 1)).ToList();
                foreach (var car in resultByTires)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                var resultByType = allCars.Where(x => x.Cargo.CargoType == command).ToList();
                var resultByEngine = resultByType.Where(x => x.Engine.EnginePower > 250).ToList();
                foreach (var car in resultByEngine)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
