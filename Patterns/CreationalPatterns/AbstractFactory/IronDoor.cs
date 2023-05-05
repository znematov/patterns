namespace Patterns.AbstractFactory;

public class IronDoor : IDoor
{
    public void GetDescription()
    {
        Console.WriteLine("Iron door");
    }
}