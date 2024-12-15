namespace DesignPatters1.StructuralPatterns.Adapter.WithoutAdapter;

public class AdapterN : ITargetN
{
    public string GetRequest()
    {
        return "Hardcoded response from Adapter, ignoring Adaptee.";
    }
}