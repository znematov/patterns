namespace Patterns.Structural.Adapter.Traveller;

public class Traveller
{
    public void Travel(ITransport transport)
    {
        transport.Drive();
    }
}