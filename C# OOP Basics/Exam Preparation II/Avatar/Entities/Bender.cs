public abstract class Bender
{
    private string name;
    private int power;

    public Bender(string name, int power)
    {
        this.name = name;
        this.Power = power;
    }

    public string Name => this.name;

    public int Power
    {
        get { return this.power; }
        set { this.power = value; }
    }

    public abstract double GetPower();

    public override string ToString()
    {
        var name = this.GetType().Name;
        var index = name.IndexOf("Bender");
        name = name.Insert(index, " ");

        return $"###{name}: {this.Name}, Power: {this.Power},";
    }

}