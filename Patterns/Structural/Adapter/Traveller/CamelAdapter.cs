namespace Patterns.Structural.Adapter.Traveller;

public class CamelAdapter : ITransport
{
    private readonly Camel _camel;
    public CamelAdapter(Camel camel)
    {
        _camel = camel;
    }

    public void Drive()
    {
        _camel.Move();
    }
}