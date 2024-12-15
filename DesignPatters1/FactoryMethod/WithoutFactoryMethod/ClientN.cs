namespace DesignPatters1.FactoryMethod.WithoutFactoryMethod;

public class ClientN
{
    public static void Main()
    {
        Console.WriteLine("App: Launched with Product1.");
        ClientCode("Product1");

        Console.WriteLine("");

        Console.WriteLine("App: Launched with Product2.");
        ClientCode("Product2");
    }

    public static void ClientCode(string productType)
    {
        object product;

        if (productType == "Product1")
        {
            product = new Product1N();
        }
        else if (productType == "Product2")
        {
            product = new Product2N();
        }
        else
        {
            throw new ArgumentException("Unknown product type");
        }

        var result = product.GetType().GetMethod("Operation")?.Invoke(product, null);

        Console.WriteLine("Client: I'm tightly coupled to the product's class, but it works.\n" + result);
    }
}
