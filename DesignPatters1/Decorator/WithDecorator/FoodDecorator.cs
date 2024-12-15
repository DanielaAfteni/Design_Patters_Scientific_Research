namespace DesignPatters1.Decorator.WithDecorator;

public abstract class FoodDecorator : IFood
{
    public IFood _food;

    public FoodDecorator(IFood food)
    {
        _food = food;
    }

    public virtual double GetCost()
    {
        return _food.GetCost();
    }

    public virtual string GetDescription()
    {
        return _food.GetDescription();
    }
}