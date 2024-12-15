namespace DesignPatters1.Prototype.WithoutProptotype;

public class RectangleN : IShapeN
{
    private readonly int _width;
    private readonly int _height;

    public RectangleN(int width, int height)
    {
        _width = width;
        _height = height;
    }
    public double GetArea()
    {
        return _width * _height;
    }

    public double GetPerimeter()
    {
        return 2 * (_height + _width);
    }
}