namespace DesignPatters1.StructuralPatterns.Bridge.WithBrigde;

public class Client
{
    public void ClientCode(Abstraction abstraction)
    {
        Console.Write(abstraction.Operation());
    }
}
