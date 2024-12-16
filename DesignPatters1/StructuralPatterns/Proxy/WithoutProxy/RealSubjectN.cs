namespace DesignPatters1.StructuralPatterns.Proxy.WithoutProxy;

public class RealSubjectN : ISubjectN
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling Request.");
    }
}