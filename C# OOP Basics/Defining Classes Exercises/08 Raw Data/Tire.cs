namespace RawData
{
    public class Tire
    {
        public int TireAge { get; set; }
        public double TirePressure { get; set; }

        public Tire(double tirePressure, int tireAge)
        {
            this.TireAge = tireAge;
            this.TirePressure = tirePressure;
        }
    }
}
