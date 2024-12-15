using DesignPatters1.StructuralPatterns.Bridge.WithBrigde;

namespace DesignPatters1.StructuralPatterns.Bridge.WithoutBrigde;

public class ClientN
{
    public static void Main()
    {
        // The client code is tightly coupled to the Abstraction and has to
        // decide which implementation to use via a boolean flag.
        AbstractionN abstraction = new AbstractionN();

        // No dynamic combination of abstraction and implementation is possible.
        Console.WriteLine("Client using Abstraction with ConcreteImplementationA:");
        Console.WriteLine(abstraction.Operation(true));

        Console.WriteLine("Client using Abstraction with ConcreteImplementationB:");
        Console.WriteLine(abstraction.Operation(false));
    }
}