using System;

public abstract class Monument
{
    private string name;

    public Monument(string name)
    {
        this.name = name;
    }

    public string Name => this.name;

    public abstract double GetPoints();

    public override string ToString()
    {
        var name = this.GetType().Name;
        var index = name.IndexOf("Monument");
        name = name.Insert(index, " ");
        return $"###{name}: {this.Name},";
    }
}