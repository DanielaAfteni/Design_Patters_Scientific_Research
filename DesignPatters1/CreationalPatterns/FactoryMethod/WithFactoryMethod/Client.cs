﻿namespace DesignPatters1.CreationalPatterns.FactoryMethod.WithFactoryMethod;

public class Client
{
    public static void Main()
    {
        Console.WriteLine("App: Launched with the ConcreteCreator1.");
        ClientCode(new ConcreteCreator1());

        Console.WriteLine("");

        Console.WriteLine("App: Launched with the ConcreteCreator2.");
        ClientCode(new ConcreteCreator2());
    }

    public static void ClientCode(Creator creator)
    {
        Console.WriteLine("Client: I'm not aware of the creator's class," +
            "but it still works.\n" + creator.SomeOperation());
    }
}