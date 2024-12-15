using DesignPatters1.Prototype.WithProptotype;

namespace DesignPatters1.Prototype.WithoutProptotype;

public class ExampleN
{
    public static void Main()
    {
        var rectangle1 = new Rectangle(100, 50);
        var rectangle2 = new Rectangle(100, 50);

        var circle1 = new Circle(30);
        var circle2 = new Circle(30);

        Client.ProcessShape(rectangle2, circle2);
    }
}