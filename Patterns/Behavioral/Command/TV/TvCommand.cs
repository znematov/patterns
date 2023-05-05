using System.Data;
using System.Windows.Input;

namespace Patterns.Behavioral.Command.TV;

public class TvCommand : ICommand
{
    private readonly TV _tvSet;

    public TvCommand(TV tvSet)
    {
        _tvSet = tvSet;
    }
    public void Execute()
    {
        _tvSet.On();
    }

    public void Undo()
    {
        _tvSet.Off();
    }
}