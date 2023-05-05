namespace Patterns.Structural.Decorator.Pizza;

public class CheesePizza : PizzaDecorator
{
    public CheesePizza(Pizza pizza) : base(pizza.Name + " with cheese", pizza)
    {
    }

    public override int GetCost()
    {
        return Pizza.GetCost() + 5;
    }
}