namespace DesignPatters1.StructuralPatterns.Proxy.WithoutProxy;

public class ClientN
{
    public void ClientCode(ProxyN proxy)
    {
        proxy.Request();
    }
}