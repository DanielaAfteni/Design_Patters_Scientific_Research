namespace DesignPatters1.StructuralPatterns.Bridge.WithBrigde;

public class ConcreteImplementationA : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: The result in platform A.\n";
    }
}