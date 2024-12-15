namespace DesignPatters1.StructuralPatterns.Bridge.WithoutBrigde;

public class ConcreteImplementationAN : IImplementationN
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: The result in platform A.\n";
    }
}