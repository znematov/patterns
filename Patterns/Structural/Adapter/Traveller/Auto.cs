namespace Patterns.Structural.Adapter.Traveller;

public class Auto : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Automobile is driving...");
    }
}