﻿namespace DesignPatters1.StructuralPatterns.Bridge.WithBrigde;

public class ConcreteImplementationB : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationB: The result in platform B.\n";
    }
}