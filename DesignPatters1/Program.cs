// See https://aka.ms/new-console-template for more information

using DesignPatters1.CreationalPatterns.Singleton.WithSingleton;
using DesignPatters1.StructuralPatterns.Composite.WithComposite;
using DesignPatters1.StructuralPatterns.Composite.WithoutComposite;
using DesignPatters1.StructuralPatterns.Decorator.WithDecorator;
using DesignPatters1.StructuralPatterns.Decorator.WithoutDecorator;


DesignPatters1.CreationalPatterns.Prototype.WithProptotype.Example.Main();
DesignPatters1.CreationalPatterns.Prototype.WithoutProptotype.ExampleN.Main();
Console.WriteLine();

ExampleDecorator.Main();
ExampleNoDecoratorN.Main();
Console.WriteLine();

DesignPatters1.StructuralPatterns.Composite.WithComposite.Client.Main();
ClientN.Main();
Console.WriteLine();

DesignPatters1.CreationalPatterns.FactoryMethod.WithFactoryMethod.Client.Main();
DesignPatters1.CreationalPatterns.FactoryMethod.WithoutFactoryMethod.ClientN.Main();
Console.WriteLine();

DesignPatters1.CreationalPatterns.Builder.WithBuilder.Client.Main();
DesignPatters1.CreationalPatterns.Builder.WithoutBuilder.ClientN.Main();
Console.WriteLine();

DesignPatters1.CreationalPatterns.AbstractFactory.WithAbtractFactory.Client.Main();
DesignPatters1.CreationalPatterns.AbstractFactory.WithoutAbtractFactory.ClientN.Main();
Console.WriteLine();

DesignPatters1.CreationalPatterns.Singleton.WithoutSingleton.ClientN.Main();
DesignPatters1.CreationalPatterns.Singleton.WithSingleton.Client.Main();
Console.WriteLine();

DesignPatters1.StructuralPatterns.Adapter.WithAdapter.Client.Main();
DesignPatters1.StructuralPatterns.Adapter.WithoutAdapter.ClientN.Main();
Console.WriteLine();

DesignPatters1.StructuralPatterns.Bridge.WithBrigde.Example.Main();
DesignPatters1.StructuralPatterns.Bridge.WithoutBrigde.ClientN.Main();  
Console.WriteLine();

DesignPatters1.StructuralPatterns.Facade.WithFacade.Example.Main();
Console.WriteLine();
Console.WriteLine();
DesignPatters1.StructuralPatterns.Facade.WithoutFacade.ClientN.Main();  
Console.WriteLine();

DesignPatters1.StructuralPatterns.Flyweight.WithFlyweight.Client.Main();
DesignPatters1.StructuralPatterns.Flyweight.WithoutFlyweight.ClientN.Main();
Console.WriteLine();


DesignPatters1.StructuralPatterns.Proxy.WithProxy.Example.Main();
DesignPatters1.StructuralPatterns.Proxy.WithoutProxy.ExampleN.Main();
Console.WriteLine();

DesignPatters1.BehavioralPattern.ChainOfResponsibility.WithChainOfResponsibility.Example.Main();
DesignPatters1.BehavioralPattern.ChainOfResponsibility.WithoutChainOfResponsibility.ExampleN.Main();
Console.WriteLine();