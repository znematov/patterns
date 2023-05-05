namespace Patterns.Structural.Adapter.HuntingGame;

public class WildDogAdapter : ILion
{
    private readonly WildDog _dog;
    public WildDogAdapter(WildDog dog)
    {
        _dog = dog;
    }
    public void Roar()
    {
        _dog.Bark();
    }
}