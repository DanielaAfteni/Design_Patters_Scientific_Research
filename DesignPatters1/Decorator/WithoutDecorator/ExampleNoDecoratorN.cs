using DesignPatters1.Decorator.WithoutDecorator;

namespace DesignPatters1.Decorator.WithoutDecorator;

public class ExampleNoDecoratorN
{
    public static void Main()
    {
        IFoodN food = new SandwichN();
        Console.WriteLine($"Your order: {food.GetDescription()}");
        Console.WriteLine($"The cost: {food.GetCost()}");

        food = new FoodWithCheeseN(food);
        Console.WriteLine($"Your order: {food.GetDescription()}");
        Console.WriteLine($"The cost: {food.GetCost()}");

        food = new FoodWithSpicesN(food);
        Console.WriteLine($"Your order: {food.GetDescription()}");
        Console.WriteLine($"The cost: {food.GetCost()}");
    }
}