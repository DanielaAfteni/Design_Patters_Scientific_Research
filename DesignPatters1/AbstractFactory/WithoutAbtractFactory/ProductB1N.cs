namespace DesignPatters1.AbstractFactory.WithoutAbtractFactory;

public class ProductB1N
{
    public string UsefulFunctionB()
    {
        return "The result of the product B1.";
    }

    public string AnotherUsefulFunctionB(ProductA1N collaborator)
    {
        var result = collaborator.UsefulFunctionA();
        return $"The result of the B1 collaborating with the ({result})";
    }
}