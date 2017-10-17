public class AirMonument : Monument
{
    private int airAffinity;

    public AirMonument(string name, int airAffinity) : base(name)
    {
        this.airAffinity = airAffinity;
    }


    public override double GetPoints() => this.airAffinity;

    public override string ToString()
    {
        return $"{base.ToString()} Air Affinity: {this.airAffinity}";
    }

}