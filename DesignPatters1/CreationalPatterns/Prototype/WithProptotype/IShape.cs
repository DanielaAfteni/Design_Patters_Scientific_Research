namespace DesignPatters1.CreationalPatterns.Prototype.WithProptotype;

public interface IShape
{
    IShape Clone();
    double GetArea();
    double GetPerimeter();
}