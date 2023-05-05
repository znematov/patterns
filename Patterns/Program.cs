using Patterns.AbstractFactory;
using Patterns.Behavioral.Command.TV;
using Patterns.FabricMethod.Interview;
using Patterns.Structural.Adapter.HuntingGame;
using Patterns.Structural.Adapter.Traveller;
using Patterns.Structural.Decorator.Coffee;
using Patterns.Structural.Decorator.Pizza;

/*HiringManager devMan = new DevelopmentManager();
devMan.TakeInterview();
HiringManager comMan = new CommunityExecutiveManager();
comMan.TakeInterview();

WoodenDoorFactory woodenDoorFactory = new WoodenDoorFactory();
woodenDoorFactory.GetDoor().GetDescription();
woodenDoorFactory.GetExpert().GetDescription();

IronDoorFactory ironDoorFactory = new IronDoorFactory();
ironDoorFactory.GetDoor().GetDescription();
ironDoorFactory.GetExpert().GetDescription();*/


/*Hunter hunter = new();
ILion asianLion = new AsianLion();
ILion africanLion = new AfricanLion();
WildDog wildDog = new();
WildDogAdapter wildDogAdapter = new WildDogAdapter(wildDog);

hunter.Hunt(asianLion);
hunter.Hunt(africanLion);
hunter.Hunt(wildDogAdapter);*/

/*Traveller traveller = new();
ITransport auto = new Auto();

Camel camel = new Camel();
CamelAdapter camelAdapter = new CamelAdapter(camel);


traveller.Travel(auto);
traveller.Travel(camelAdapter);*/


/*Pizza p1 = new ItalianPizza();
p1 = new TomatoPizza(p1);
p1 = new CheesePizza(p1);
Console.WriteLine(p1.Name);
Console.WriteLine(p1.GetCost());*/

/*ICoffee coffee = new SimpleCoffee();
coffee = new MilkCoffee(coffee);
coffee = new VanillaCoffee(coffee);
Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()}");*/

Pult pult = new Pult();
TV tv = new TV();
pult.SetCommand(new TvCommand(tv));
pult.PressButton();
pult.PressUndo();