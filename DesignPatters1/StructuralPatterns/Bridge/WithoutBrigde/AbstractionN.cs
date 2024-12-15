namespace DesignPatters1.StructuralPatterns.Bridge.WithoutBrigde;

public class AbstractionN
{
    private ConcreteImplementationAN _implementationA;
    private ConcreteImplementationBN _implementationB;

    public AbstractionN()
    {
        _implementationA = new ConcreteImplementationAN();
        _implementationB = new ConcreteImplementationBN();
    }

    public string Operation(bool useA)
    {
        if (useA)
        {
            return "Abstraction using A:\n" + _implementationA.OperationImplementation();
        }
        else
        {
            return "Abstraction using B:\n" + _implementationB.OperationImplementation();
        }
    }
}