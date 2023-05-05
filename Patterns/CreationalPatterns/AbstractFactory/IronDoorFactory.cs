namespace Patterns.AbstractFactory;

public class IronDoorFactory : IDoorFactory
{
    public IDoor GetDoor()
    {
        return new IronDoor();
    }

    public IDoorFittingExpert GetExpert()
    {
        return new IronDoorFittingExpert();
    }
}