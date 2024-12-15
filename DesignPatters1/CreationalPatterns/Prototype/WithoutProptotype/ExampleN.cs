using DesignPatters1.CreationalPatterns.Prototype.WithProptotype;

namespace DesignPatters1.CreationalPatterns.Prototype.WithoutProptotype;

public class ExampleN
{
    public static void Main()
    {
        var rectangle1 = new RectangleN(100, 50);
        var rectangle2 = new RectangleN(100, 50);

        var circle1 = new CircleN(30);
        var circle2 = new CircleN(30);

        ClientN.ProcessShape(rectangle2, circle2);
    }
}