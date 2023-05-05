using Patterns.AbstractFactory;
using Patterns.FabricMethod.Interview;

HiringManager devMan = new DevelopmentManager();
devMan.TakeInterview();
HiringManager comMan = new CommunityExecutiveManager();
comMan.TakeInterview();

WoodenDoorFactory woodenDoorFactory = new WoodenDoorFactory();
woodenDoorFactory.GetDoor().GetDescription();
woodenDoorFactory.GetExpert().GetDescription();

IronDoorFactory ironDoorFactory = new IronDoorFactory();
ironDoorFactory.GetDoor().GetDescription();
ironDoorFactory.GetExpert().GetDescription();