namespace Patterns.Structural.Adapter.Traveller;

public class Camel : IAnimal
{
    public void Move()
    {
        Console.WriteLine("A camel walks in the deserts...");
    }
}