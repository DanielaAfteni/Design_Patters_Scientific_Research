namespace DesignPatters1.CreationalPatterns.FactoryMethod.WithFactoryMethod;

public class ConcreteCreator2 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct2();
    }
}
