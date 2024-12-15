namespace DesignPatters1.CreationalPatterns.FactoryMethod.WithFactoryMethod;

public class ConcreteCreator1 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}
