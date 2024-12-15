namespace DesignPatters1.Decorator.WithoutDecorator;

public class SandwichN : IFoodN
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