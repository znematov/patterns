namespace Patterns.AbstractFactory;

public class WoodenDoorFactory : IDoorFactory
{
    public IDoor GetDoor()
    {
        return new WoodenDoor();
    }

    public IDoorFittingExpert GetExpert()
    {
        return new WoodenDoorExpert();
    }
}