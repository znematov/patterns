namespace Patterns.FabricMethod.Interview;

public abstract class HiringManager
{
    protected abstract IInterviewer MakeInterview();

    public void TakeInterview()
    {
        MakeInterview().AskQuestions();
    }
}