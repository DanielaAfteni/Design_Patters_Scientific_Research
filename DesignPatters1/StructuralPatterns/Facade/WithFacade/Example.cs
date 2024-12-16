namespace DesignPatters1.StructuralPatterns.Facade.WithFacade;

public class Example
{
    public static void Main()
    {
        Subsystem1 subsystem1 = new Subsystem1();
        Subsystem2 subsystem2 = new Subsystem2();
        Facade facade = new Facade(subsystem1, subsystem2);
        Client.ClientCode(facade);
    }
}