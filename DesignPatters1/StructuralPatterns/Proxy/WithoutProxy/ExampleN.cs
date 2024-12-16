namespace DesignPatters1.StructuralPatterns.Proxy.WithoutProxy;

public class ExampleN
{
    public static void Main()
    {
        Console.WriteLine("Client: Using Proxy directly:");

        ProxyN proxy = new ProxyN();

        ClientN client = new ClientN();
        client.ClientCode(proxy);
    }
}