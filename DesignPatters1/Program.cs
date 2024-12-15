// See https://aka.ms/new-console-template for more information

using DesignPatters1.Decorator.WithDecorator;
using DesignPatters1.Decorator.WithoutDecorator;
using DesignPatters1.Prototype.WithoutProptotype;
using DesignPatters1.Prototype.WithProptotype;

Example.Main();
ExampleN.Main();
Console.WriteLine();

ExampleDecorator.Main();
ExampleNoDecoratorN.Main();
Console.WriteLine();

DesignPatters1.Composite.WithComposite.Client.Main();
DesignPatters1.Composite.WithoutComposite.ClientN.Main();
Console.WriteLine();

DesignPatters1.FactoryMethod.WithFactoryMethod.Client.Main();
DesignPatters1.FactoryMethod.WithoutFactoryMethod.ClientN.Main();
Console.WriteLine();

DesignPatters1.Builder.WithBuilder.Client.Main();
DesignPatters1.Builder.WithoutBuilder.ClientN.Main();
Console.WriteLine();

DesignPatters1.AbstractFactory.WithAbtractFactory.Client.Main();
DesignPatters1.AbstractFactory.WithoutAbtractFactory.ClientN.Main();
Console.WriteLine();