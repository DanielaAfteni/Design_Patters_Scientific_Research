namespace DesignPatters1.AbstractFactory.WithAbtractFactory;

public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();

    IAbstractProductB CreateProductB();
}