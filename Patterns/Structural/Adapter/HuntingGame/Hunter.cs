namespace Patterns.Structural.Adapter.HuntingGame;

public class Hunter
{
    public void Hunt(ILion lion)
    {
        lion.Roar();
        Console.WriteLine($"Successfully hunted! Your prey is: {lion.GetType()}");
    }
}