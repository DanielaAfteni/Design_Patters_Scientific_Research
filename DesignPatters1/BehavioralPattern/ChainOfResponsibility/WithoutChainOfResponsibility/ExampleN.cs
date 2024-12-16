using DesignPatters1.BehavioralPattern.ChainOfResponsibility.WithChainOfResponsibility;

namespace DesignPatters1.BehavioralPattern.ChainOfResponsibility.WithoutChainOfResponsibility;

public class ExampleN
{
    public static void Main()
    {
        var monkey = new MonkeyHandler();
        var squirrel = new SquirrelHandler();
        var dog = new DogHandler();

        monkey.SetNext(squirrel);
        squirrel.SetNext(dog);

        Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
        Client.ClientCode(monkey);

        Console.WriteLine();

        Console.WriteLine("Subchain: Squirrel > Dog\n");
        Client.ClientCode(squirrel);
    }
}