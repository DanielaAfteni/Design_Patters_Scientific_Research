using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters1.AbstractFactory.WithoutAbtractFactory;

public class ClientN
{
    public static void Main()
    {
        Console.WriteLine("Client: Testing client code with the first product variant...");
        var productA1 = new ProductA1N();
        var productB1 = new ProductB1N();

        Console.WriteLine(productB1.UsefulFunctionB());
        Console.WriteLine(productB1.AnotherUsefulFunctionB(productA1));

        Console.WriteLine();

        Console.WriteLine("Client: Testing client code with the second product variant...");
        var productA2 = new ProductA2N();
        var productB2 = new ProductB2N();

        Console.WriteLine(productB2.UsefulFunctionB());
        Console.WriteLine(productB2.AnotherUsefulFunctionB(productA2));
    }
}