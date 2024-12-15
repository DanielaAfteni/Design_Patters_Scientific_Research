namespace DesignPatters1.CreationalPatterns.AbstractFactory.WithAbtractFactory;

public interface IAbstractProductB
{
    string UsefulFunctionB();
    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}