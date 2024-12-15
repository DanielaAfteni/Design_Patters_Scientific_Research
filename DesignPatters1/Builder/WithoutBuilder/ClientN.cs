using DesignPatters1.Builder.WithBuilder;

namespace DesignPatters1.Builder.WithoutBuilder;

public class ClientN
{
    public static void Main()
    {
        Product product = new Product();

        Console.WriteLine("Building product manually:");
        product.Add("PartA");
        product.Add("PartB");
        product.Add("PartC");

        Console.WriteLine(product.ListParts());

        Product anotherProduct = new Product();

        Console.WriteLine("\nBuilding another product manually:");
        anotherProduct.Add("PartX");
        anotherProduct.Add("PartY");

        Console.WriteLine(anotherProduct.ListParts());
    }
}