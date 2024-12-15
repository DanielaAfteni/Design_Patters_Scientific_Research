namespace DesignPatters1.StructuralPatterns.Decorator.WithDecorator;

public class Sandwich : IFood
{
    public double GetCost()
    {
        return 1.0;
    }

    public string GetDescription()
    {
        return "Sandwich";
    }
}