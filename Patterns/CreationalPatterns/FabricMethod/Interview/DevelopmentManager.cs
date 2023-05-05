namespace Patterns.FabricMethod.Interview;

public class DevelopmentManager : HiringManager
{
    protected override IInterviewer MakeInterview()
    {
        return new Developer();
    }
}