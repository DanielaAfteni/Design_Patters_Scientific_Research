using DesignPatters1.StructuralPatterns.Adapter.WithAdapter;

namespace DesignPatters1.StructuralPatterns.Adapter.WithoutAdapter;

public class ClientN
{
    public static void Main()
    {
        AdapteeN adaptee = new AdapteeN();

        ITargetN target = new AdapterN();

        Console.WriteLine("Client thinks it's using an adapted Adaptee:");
        Console.WriteLine(target.GetRequest());
    }
}