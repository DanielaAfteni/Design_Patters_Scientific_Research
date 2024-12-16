namespace DesignPatters1.StructuralPatterns.Flyweight.WithoutFlyweight;

public class FlyweightFactoryN
{
    public List<Tuple<FlyweightN, string>> Flyweights = new List<Tuple<FlyweightN, string>>();

    public FlyweightFactoryN(params CarN[] args)
    {
        foreach (var elem in args)
        {
            Flyweights.Add(new Tuple<FlyweightN, string>(new FlyweightN(elem), GetKey(elem)));
        }
    }

    public string GetKey(CarN key)
    {
        List<string> elements = new List<string> { key.Model, key.Color, key.Company };
        if (key.Owner != null && key.Number != null)
        {
            elements.Add(key.Number);
            elements.Add(key.Owner);
        }
        elements.Sort();
        return string.Join("_", elements);
    }

    public FlyweightN GetFlyweight(CarN sharedState)
    {
        string key = GetKey(sharedState);
        if (!Flyweights.Any(t => t.Item2 == key))
        {
            Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
            Flyweights.Add(new Tuple<FlyweightN, string>(new FlyweightN(sharedState), key));
        }
        else
        {
            Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
        }

        return Flyweights.FirstOrDefault(t => t.Item2 == key)?.Item1;
    }

    public void ListFlyweights()
    {
        Console.WriteLine($"\nFlyweightFactory: I have {Flyweights.Count} flyweights:");
        foreach (var flyweight in Flyweights)
        {
            Console.WriteLine(flyweight.Item2);
        }
    }
}