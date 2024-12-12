namespace DesignPatters1.Prototype;

public interface IShape
{
    IShape Clone();
    double GetArea();
    double GetPerimeter();  
}
