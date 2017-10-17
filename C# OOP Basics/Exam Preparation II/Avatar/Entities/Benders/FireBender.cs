public class FireBender : Bender
{
    private double heatAggression;

    public FireBender(string name, int power, double heatAggression) : base(name, power)
    {
        this.heatAggression = heatAggression;
    }

    public override double GetPower()
    {
        return base.Power * heatAggression;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Heat Aggression: {heatAggression:f2}";
        
    }
}