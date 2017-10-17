using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    protected Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsepower = horsepower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
    }

    public int Horsepower
    {
        get { return this.horsepower; }
        set { this.horsepower = value; }
    }
    public int Acceleration => this.acceleration;

    public int Suspension
    {
        get { return this.suspension; }
        set { this.suspension = value; }
    }
    public int Durability => this.durability;

    public string Brand => this.brand;
    public string Model => this.model;

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{Brand} {model} {yearOfProduction}")
            .AppendLine($"{horsepower} HP, 100 m/h in {acceleration} s")
            .AppendLine($"{suspension} Suspension force, {durability} Durability");
        return sb.ToString();
    }

    public virtual void Tune(int tuneIndex, string addOn)
    {
        this.Horsepower += tuneIndex;
        this.Suspension += tuneIndex / 2;

    }
}