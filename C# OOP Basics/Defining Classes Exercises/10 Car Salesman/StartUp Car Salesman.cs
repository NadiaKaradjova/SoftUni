namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Car_Salesman
    {
        public static void Main()
        {
            var engines = new List<Engine>();
            var cars = new List<Car>();

            var engineNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < engineNumber; i++)
            {
                var engineInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var engineModel = engineInfo[0];
                var enginePower = int.Parse(engineInfo[1]);

                var currentEngine = new Engine(engineModel, enginePower);

                if (engineInfo.Length > 2)
                {
                    var displacement = 0;
                    if (int.TryParse(engineInfo[2], out displacement))
                    {
                        currentEngine.Displacement = displacement.ToString();
                    }
                    else
                    {
                        currentEngine.Efficiency = engineInfo[2];
                    }
                }

                if (engineInfo.Length > 3)
                {
                    currentEngine.Efficiency = engineInfo[3];
                }
                engines.Add(currentEngine);

            }
            var carNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < carNumber; i++)
            {
                var carInfo = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var carModel = carInfo[0];
                var carEngine = carInfo[1];

                var currentCar = new Car(carModel, carEngine);

                if (carInfo.Length > 2)
                {
                    var weight = 0;
                    if (int.TryParse(carInfo[2], out weight))
                    {
                        currentCar.Weight = weight.ToString();
                    }
                    else
                    {
                        currentCar.Color = carInfo[2];
                    }

                    if (carInfo.Length > 3)
                    {
                        currentCar.Color = carInfo[3];
                    }
                }
                cars.Add(currentCar);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine}:");
                foreach (var engine in engines.Where(x => x.Model == car.Engine))
                {
                    Console.WriteLine($"    Power: {engine.Power}");
                    Console.WriteLine($"    Displacement: {engine.Displacement}");
                    Console.WriteLine($"    Efficiency: {engine.Efficiency}");
                }
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
            
        }
    }
}
