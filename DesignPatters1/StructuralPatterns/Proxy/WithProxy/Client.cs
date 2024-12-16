namespace DesignPatters1.StructuralPatterns.Proxy.WithProxy;

public class Client
{
    public void ClientCode(ISubject subject)
    {
        // ...

        subject.Request();

        // ...
    }
}