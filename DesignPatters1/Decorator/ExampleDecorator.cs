namespace DesignPatters1.Decorator;

public class ExampleDecorator
{
    public static void Main()
    {
        IFood food = new Sandwich();
        Console.WriteLine($"Your order: {food.GetDescription()}");
        Console.WriteLine($"The cost: {food.GetCost()}");
        
        food = new CheeseDecorator(food);
        Console.WriteLine($"Your order: {food.GetDescription()}");
        Console.WriteLine($"The cost: {food.GetCost()}");

        food = new SpiceDecorator(food);
        Console.WriteLine($"Your order: {food.GetDescription()}");
        Console.WriteLine($"The cost: {food.GetCost()}");
    }
}