using DesignPatters1.StructuralPatterns.Flyweight.WithFlyweight;

namespace DesignPatters1.StructuralPatterns.Flyweight.WithoutFlyweight;

public class ClientN
{
    public static void Main()
    {
        var factory = new FlyweightFactoryN(
            new CarN { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
            new CarN { Company = "Mercedes Benz", Model = "C300", Color = "black" },
            new CarN { Company = "Mercedes Benz", Model = "C500", Color = "red" },
            new CarN { Company = "BMW", Model = "M5", Color = "red" },
            new CarN { Company = "BMW", Model = "X6", Color = "white" }
        );

        factory.ListFlyweights();

        AddCarToPoliceDatabase(factory, new CarN
        {
            Number = "CL234IR",
            Owner = "James Doe",
            Company = "BMW",
            Model = "M5",
            Color = "red"
        });

        AddCarToPoliceDatabase(factory, new CarN
        {
            Number = "CL234IR",
            Owner = "James Doe",
            Company = "BMW",
            Model = "X1",
            Color = "red"
        });

        factory.ListFlyweights();
    }

    public static void AddCarToPoliceDatabase(FlyweightFactoryN factory, CarN car)
    {
        Console.WriteLine("\nClient: Adding a car to database.");

        // Shared state extraction is clunky and error-prone.
        var flyweight = factory.GetFlyweight(new CarN
        {
            Color = car.Color,
            Model = car.Model,
            Company = car.Company
        });

        // Operation improperly mixes shared and unique states.
        flyweight.Operation(car);
    }
}