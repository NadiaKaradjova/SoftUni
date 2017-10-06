using System;

namespace SpeedRacing
{
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumation;
        private double amountOfKm;

        public Car(string model, double fuelAmount, double fuelConsumation)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumation = fuelConsumation;
            this.amountOfKm = 0;
        }

        public string Model { get { return this.model; } }
        public double FuelAmount { get { return this.fuelAmount; } }
        public double AmountOfKm { get { return this.amountOfKm; } }

        public void Drive(string model, double distance)
        {
            if (distance*this.fuelConsumation <= this.fuelAmount)
            {
                this.fuelAmount -= distance * this.fuelConsumation;
                this.amountOfKm += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
