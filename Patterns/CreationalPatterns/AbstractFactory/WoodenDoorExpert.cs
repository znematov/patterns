namespace Patterns.AbstractFactory;

public class WoodenDoorExpert : IDoorFittingExpert
{
    public void GetDescription()
    {
        Console.WriteLine("I work with wooden doors");
    }
}