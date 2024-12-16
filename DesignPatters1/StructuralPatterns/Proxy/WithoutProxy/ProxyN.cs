namespace DesignPatters1.StructuralPatterns.Proxy.WithoutProxy;

public class ProxyN : ISubjectN
{
    private RealSubjectN _realSubject;

    public ProxyN()
    {
        _realSubject = new RealSubjectN();
    }

    public void Request()
    {
        Console.WriteLine("Proxy: Forwarding request to RealSubject without adding value.");
        _realSubject.Request();
    }
}