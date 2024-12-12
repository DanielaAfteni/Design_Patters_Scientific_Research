namespace DesignPatters1.Prototype;

public class Rectangle : IShape
{
    private readonly int _width;
    private readonly int _height;

    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public IShape Clone()
    {
        return new Rectangle(_width, _height);
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
