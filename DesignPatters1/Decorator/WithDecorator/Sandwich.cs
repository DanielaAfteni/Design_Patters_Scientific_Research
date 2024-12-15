namespace DesignPatters1.Decorator.WithDecorator;

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