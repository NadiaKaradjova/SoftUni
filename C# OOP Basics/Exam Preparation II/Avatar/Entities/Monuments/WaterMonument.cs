public class WaterMonument : Monument
{
    private int waterAffinity;

    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.waterAffinity = waterAffinity;
    }

    public override double GetPoints() => this.waterAffinity;

    public override string ToString()
    {
        return $"{base.ToString()} Water Affinity: {this.waterAffinity}";
    }
}