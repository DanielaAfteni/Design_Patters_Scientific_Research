namespace DesignPatters1.StructuralPatterns.Decorator.WithDecorator;

public class SpiceDecorator : FoodDecorator
{
    public SpiceDecorator(IFood food) : base(food) { }

    public override double GetCost()
    {
        return base.GetCost() + 3.0;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + " + Spices";
    }
}