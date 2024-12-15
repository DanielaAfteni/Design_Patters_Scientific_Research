namespace DesignPatters1.AbstractFactory.WithAbtractFactory;

public interface IAbstractProductB
{
    string UsefulFunctionB();
    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}