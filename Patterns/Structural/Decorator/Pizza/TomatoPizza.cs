namespace Patterns.Structural.Decorator.Pizza;

public class TomatoPizza : PizzaDecorator
{
    public TomatoPizza(Pizza pizza) : base(pizza.Name + " with tomatoes", pizza)
    {
    }

    public override int GetCost()
    {
        return Pizza.GetCost() + 3;
    }
}