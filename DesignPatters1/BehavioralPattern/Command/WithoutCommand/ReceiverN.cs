﻿namespace DesignPatters1.BehavioralPattern.Command.WithoutCommand;

public class ReceiverN
{
    public void DoSomething(string a)
    {
        Console.WriteLine($"Receiver: Working on ({a}.)");
    }

    public void DoSomethingElse(string b)
    {
        Console.WriteLine($"Receiver: Also working on ({b}.)");
    }
}