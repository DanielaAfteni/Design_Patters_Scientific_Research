﻿namespace DesignPatters1.StructuralPatterns.Bridge.WithBrigde;

public class ExtendedAbstraction : Abstraction
{
    public ExtendedAbstraction(IImplementation implementation) : base(implementation) { }

    public override string Operation()
    {
        return "ExtendedAbstraction: Extended operation with:\n" +
            base._implementation.OperationImplementation();
    }
}