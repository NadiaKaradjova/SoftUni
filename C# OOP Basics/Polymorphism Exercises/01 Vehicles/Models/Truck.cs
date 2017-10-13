namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AcConsumptionMod = 1.6;
        private const double FuelLossFactor = 0.95;

        public Truck(double fuelQuantity, double fuelConsumptionLitersPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionLitersPerKm + AcConsumptionMod, tankCapacity)
        {
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel*FuelLossFactor);
        }
    }
}
