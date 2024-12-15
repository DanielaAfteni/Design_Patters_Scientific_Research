namespace DesignPatters1.AbstractFactory.WithoutAbtractFactory;

public class ProductB2N
{
    public string UsefulFunctionB()
    {
        return "The result of the product B2.";
    }

    public string AnotherUsefulFunctionB(ProductA2N collaborator)
    {
        var result = collaborator.UsefulFunctionA();
        return $"The result of the B2 collaborating with the ({result})";
    }
}