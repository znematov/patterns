namespace Patterns.Structural.Decorator.Coffee;

public class VanillaCoffee : ICoffee
{
    private readonly ICoffee _coffee;

    public VanillaCoffee(ICoffee coffee)
    {
        _coffee = coffee;
    }
    public string GetDescription()
    {
        return _coffee.GetDescription() + ", with vanilla";
    }

    public int GetCost()
    {
        return _coffee.GetCost() + 5;
    }
}