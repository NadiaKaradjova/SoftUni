using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumptionLitersPerKm, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionLitersPerKm = fuelConsumptionLitersPerKm;
            
        }

        protected double FuelConsumptionLitersPerKm { get; set; }

        protected virtual double FuelQuantity { get; set; }

        protected virtual double TankCapacity { get; set; }

        protected virtual bool Drive(double distance, bool ifAcOn)
        {
            var fuelRequired = distance * this.FuelConsumptionLitersPerKm;
            if (fuelRequired > this.FuelQuantity)
            {
                return false;
            }
            this.FuelQuantity -= fuelRequired;
            return true;
        }

        public string TryTravelDistance(double distance, bool ifAcOn)
        {
            if (this.Drive(distance, ifAcOn))
            {
                return $"{this.GetType().Name} travelled {distance} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }

        public string TryTravelDistance(double distance)
        {
            return TryTravelDistance(distance, true);
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += fuel;
        } 

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}