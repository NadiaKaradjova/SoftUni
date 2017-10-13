using System;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double AcConsumptionMod = 1.4;

        public Bus(double fuelQuantity, double fuelConsumptionLitersPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionLitersPerKm, tankCapacity)
        {
        }

        protected override double FuelQuantity
        {
            set
            {
                if (value > this.TankCapacity)
                {
                 throw   new ArgumentException("Cannot fit fuel in tank");
                }
                base.FuelQuantity = value;
            }
        }

        protected override bool Drive(double distance, bool ifAcOn)
        {
            double requiaredFuel = 0;
            if (ifAcOn)
            {
                requiaredFuel = distance * (this.FuelConsumptionLitersPerKm + AcConsumptionMod);
            }
            else
            {
                requiaredFuel = distance * this.FuelConsumptionLitersPerKm;
            }

            if (requiaredFuel > this.FuelQuantity)
            {
                return false;
            }
            this.FuelQuantity -= requiaredFuel;
            return true;
        }
    }
}
