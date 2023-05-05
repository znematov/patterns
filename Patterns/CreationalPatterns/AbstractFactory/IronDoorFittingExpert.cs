namespace Patterns.AbstractFactory;

public class IronDoorFittingExpert : IDoorFittingExpert
{
    public void GetDescription()
    {
        Console.WriteLine("Iron door expert");
    }
}