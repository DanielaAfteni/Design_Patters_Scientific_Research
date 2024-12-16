﻿namespace DesignPatters1.BehavioralPattern.ChainOfResponsibility.WithChainOfResponsibility;

public class Example
{
    public static void Main()
    {
        var monkey = new MonkeyHandler();
        var squirrel = new SquirrelHandler();
        var dog = new DogHandler();

        monkey.SetNext(squirrel).SetNext(dog);

        Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
        Client.ClientCode(monkey);
        Console.WriteLine();

        Console.WriteLine("Subchain: Squirrel > Dog\n");
        Client.ClientCode(squirrel);
    }
}