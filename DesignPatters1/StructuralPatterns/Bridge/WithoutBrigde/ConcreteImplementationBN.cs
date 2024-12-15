namespace DesignPatters1.StructuralPatterns.Bridge.WithoutBrigde;

public class ConcreteImplementationBN : IImplementationN
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationB: The result in platform B.\n";
    }
}
