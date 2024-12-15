namespace DesignPatters1.Prototype.WithProptotype;

public interface IShape
{
    IShape Clone();
    double GetArea();
    double GetPerimeter();
}