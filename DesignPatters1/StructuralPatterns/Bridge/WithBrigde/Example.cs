namespace DesignPatters1.StructuralPatterns.Bridge.WithBrigde;

public class Example
{
    public static void Main()
    {
        Client client = new Client();

        Abstraction abstraction;
        abstraction = new Abstraction(new ConcreteImplementationA());
        client.ClientCode(abstraction);

        Console.WriteLine();

        abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
        client.ClientCode(abstraction);
    }
}