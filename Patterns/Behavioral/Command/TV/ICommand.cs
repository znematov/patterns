namespace Patterns.Behavioral.Command.TV;

public interface ICommand
{
    void Execute();
    void Undo();
}