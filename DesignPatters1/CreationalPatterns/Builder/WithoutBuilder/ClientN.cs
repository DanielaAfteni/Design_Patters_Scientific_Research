namespace DesignPatters1.CreationalPatterns.Builder.WithoutBuilder;

public class ClientN
{
    public static void Main()
    {
        ProductN basicProduct = new ProductN();
        basicProduct.Add("PartA1");

        Console.WriteLine("Standard basic product:");
        Console.WriteLine(basicProduct.ListParts());

        ProductN fullProduct = new ProductN();
        fullProduct.Add("PartA1");
        fullProduct.Add("PartB1");
        fullProduct.Add("PartC1");

        Console.WriteLine("Standard full featured product:");
        Console.WriteLine(fullProduct.ListParts());

        ProductN customProduct = new ProductN();
        customProduct.Add("PartA1");
        customProduct.Add("PartC1");

        Console.WriteLine("Custom product:");
        Console.WriteLine(customProduct.ListParts());
    }
}