namespace Patterns.Structural.Decorator.Pizza;

public abstract class Pizza
{
    public string Name { get; }

    protected Pizza(string name)
    {
        Name = name;
    }

    public abstract int GetCost();
}