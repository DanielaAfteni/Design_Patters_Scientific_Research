// See https://aka.ms/new-console-template for more information

using DesignPatters1.Decorator.WithDecorator;
using DesignPatters1.Decorator.WithoutDecorator;


DesignPatters1.CreationalPatterns.Prototype.WithProptotype.Example.Main();
DesignPatters1.CreationalPatterns.Prototype.WithoutProptotype.ExampleN.Main();
Console.WriteLine();

ExampleDecorator.Main();
ExampleNoDecoratorN.Main();
Console.WriteLine();

DesignPatters1.Composite.WithComposite.Client.Main();
DesignPatters1.Composite.WithoutComposite.ClientN.Main();
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