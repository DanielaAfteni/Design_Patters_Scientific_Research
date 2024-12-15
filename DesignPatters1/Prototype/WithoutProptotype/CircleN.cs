namespace DesignPatters1.Prototype.WithoutProptotype;

public class CircleN : IShapeN
{
    private readonly int _radius;

    public CircleN(int radius)
    {
        _radius = radius;
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