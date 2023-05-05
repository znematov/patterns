namespace Patterns.AbstractFactory;

public interface IDoorFactory
{
    IDoor GetDoor();
    IDoorFittingExpert GetExpert();
}