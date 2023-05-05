namespace Patterns.Structural.Decorator.Coffee;

public class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple coffee";
    }

    public int GetCost()
    {
        return 10;
    }
}