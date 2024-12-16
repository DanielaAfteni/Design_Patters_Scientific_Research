namespace DesignPatters1.StructuralPatterns.Proxy.WithProxy;

public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling Request.");
    }
}