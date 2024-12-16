namespace DesignPatters1.StructuralPatterns.Facade.WithFacade;

public class Client
{
    public static void ClientCode(Facade facade)
    {
        Console.Write(facade.Operation());
    }
}