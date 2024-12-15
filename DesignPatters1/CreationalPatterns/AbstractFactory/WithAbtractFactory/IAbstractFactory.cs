namespace DesignPatters1.CreationalPatterns.AbstractFactory.WithAbtractFactory;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();

    IAbstractProductB CreateProductB();
}