// See https://aka.ms/new-console-template for more information

using DesignPatters1.Decorator.WithDecorator;
using DesignPatters1.Decorator.WithoutDecorator;
using DesignPatters1.Prototype.WithoutProptotype;
using DesignPatters1.Prototype.WithProptotype;

Example.Main();
ExampleN.Main();
Console.WriteLine();

Console.WriteLine();
ExampleDecorator.Main();
ExampleNoDecoratorN.Main();

Console.WriteLine();
DesignPatters1.Composite.Client.Main();