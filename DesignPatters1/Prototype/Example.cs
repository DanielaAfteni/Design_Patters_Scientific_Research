namespace DesignPatters1.Prototype;

public static class Example
{
    public static void Main()
    {
        var rectanglePrototype = new Rectangle(100, 50);
        var rectangle = rectanglePrototype.Clone();

        var circlePrototype = new Circle(30);
        var circle = circlePrototype.Clone();

        Client.ProcessShape(rectangle, circle);
    }
}