namespace Patterns.Structural.Decorator.Coffee;

public class MilkCoffee : ICoffee
{
    private readonly ICoffee _coffee; 
    public MilkCoffee(ICoffee coffee)
    {
        _coffee = coffee;
    }
    public string GetDescription()
    {
        return $"{_coffee.GetDescription()}, with milk";
    }

    public int GetCost()
    {
        return _coffee.GetCost() + 2;
    }
}