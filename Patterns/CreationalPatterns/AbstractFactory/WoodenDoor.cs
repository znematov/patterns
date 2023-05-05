namespace Patterns.AbstractFactory;

public class WoodenDoor : IDoor
{
    public void GetDescription()
    {
        Console.WriteLine("Wooden door");
    }
}