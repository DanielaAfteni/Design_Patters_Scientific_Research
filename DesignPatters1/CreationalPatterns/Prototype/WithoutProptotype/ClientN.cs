using DesignPatters1.CreationalPatterns.Prototype.WithProptotype;

namespace DesignPatters1.CreationalPatterns.Prototype.WithoutProptotype;

public class ClientN
{
    public static void ProcessShape(IShapeN shape1, IShapeN shape2)
    {
        Console.WriteLine($"The area of shape 1 is {shape1.GetArea()} and its perimeter is {shape1.GetPerimeter()}");
        Console.WriteLine($"The area of shape 2 is {shape2.GetArea()} and its perimeter is {shape2.GetPerimeter()}");
    }
}