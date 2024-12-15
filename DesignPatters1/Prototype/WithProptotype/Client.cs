namespace DesignPatters1.Prototype.WithProptotype;

public class Client
{
    public static void ProcessShape(IShape shape1, IShape shape2)
    {
        Console.WriteLine($"The area of shape 1 is {shape1.GetArea()} and its perimeter is {shape1.GetPerimeter()}");
        Console.WriteLine($"The area of shape 2 is {shape2.GetArea()} and its perimeter is {shape2.GetPerimeter()}");
    }
}