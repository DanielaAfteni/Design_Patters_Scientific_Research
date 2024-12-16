namespace DesignPatters1.StructuralPatterns.Facade.WithoutFacade;

public class ClientN
{
    public static void Main()
    {
        FacadeN facade = new FacadeN();
        Console.WriteLine("Client calls Facade:");
        facade.Operation();

        Console.WriteLine("\nClient directly accesses subsystems:");
        facade.Subsystem1.OperationA();
        facade.Subsystem2.OperationY();
    }
}