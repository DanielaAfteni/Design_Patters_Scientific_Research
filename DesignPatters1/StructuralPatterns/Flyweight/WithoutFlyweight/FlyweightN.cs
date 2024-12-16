using System.Text.Json;

namespace DesignPatters1.StructuralPatterns.Flyweight.WithoutFlyweight;

public class FlyweightN
{
    private CarN _sharedState;

    public FlyweightN(CarN car)
    {
        this._sharedState = car;
    }

    public void Operation(CarN uniqueState)
    {
        string s = JsonSerializer.Serialize(this._sharedState);
        string u = JsonSerializer.Serialize(uniqueState);
        Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
    }

    public CarN GetSharedState()
    {
        return _sharedState;
    }
}