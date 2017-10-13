using System;
using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split();
            var truckInfo = Console.ReadLine().Split();
            var busInfo = Console.ReadLine().Split();


            Vehicle car = new Car(double.Parse(carInfo[1]), Double.Parse(carInfo[2]), Double.Parse(carInfo[3]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), Double.Parse(truckInfo[2]), Double.Parse(truckInfo[3]));
            Vehicle bus = new Bus(double.Parse(busInfo[1]), Double.Parse(busInfo[2]), Double.Parse(busInfo[3]));

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    var commandLine = Console.ReadLine().Split();
                    var vehicleType = commandLine[1];
                    var command = commandLine[0];
                    var param = double.Parse(commandLine[2]);

                    if (vehicleType == "Car")
                    {
                        ExecuteAction(car, command, param);
                    }
                    else if (vehicleType == "Truck")
                    {
                        ExecuteAction(truck, command, param);
                    }
                    else if(vehicleType == "Bus")
                    {
                        ExecuteAction(bus, command, param);
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);

        }

        private static void ExecuteAction(Vehicle vehicle, string command, double param)
        {
            switch (command)
            {
                case "Drive":
                    var result = vehicle.TryTravelDistance(param);
                    Console.WriteLine(result);
                    break;
                case "Refuel": vehicle.Refuel(param);
                    break;
                case "DriveEmpty":
                    Console.WriteLine(vehicle.TryTravelDistance(param, false));
                    break;
            }
        }
    }
}
