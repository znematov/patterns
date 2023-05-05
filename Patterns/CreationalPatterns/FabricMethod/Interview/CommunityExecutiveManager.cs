namespace Patterns.FabricMethod.Interview;

public class CommunityExecutiveManager : HiringManager
{
    protected override IInterviewer MakeInterview()
    {
        return new CommunityExecutive();
    }
}