namespace DesignPatters1.StructuralPatterns.Facade.WithoutFacade;

public class ClientN
{
    public static void Main()
    {
        FacadeN facade = new FacadeN();
        Console.WriteLine(facade.Operation());

        Console.WriteLine("\nAccessing subsystems directly:");
        Console.WriteLine(facade.Subsystem1.Operation1());
        Console.WriteLine(facade.Subsystem2.OperationZ());
    }
}