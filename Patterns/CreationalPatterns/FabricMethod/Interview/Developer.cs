namespace Patterns.FabricMethod.Interview;

public class Developer : IInterviewer
{
    public void AskQuestions()
    {
        Console.WriteLine("Ask about design patterns");
    }
}