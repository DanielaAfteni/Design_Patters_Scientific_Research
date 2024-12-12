namespace DesignPatters1.Prototype;

public class Circle : IShape
{
    private readonly int _radius;

    public Circle(int radius)
    {
        _radius = radius;
    }

    public IShape Clone()
    {
        return new Circle(_radius);
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * _radius;
    }
}
