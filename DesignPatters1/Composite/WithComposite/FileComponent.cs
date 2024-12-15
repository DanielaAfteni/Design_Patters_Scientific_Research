namespace DesignPatters1.Composite.WithComposite;

public class FileComponent
{
    public string _name { get; set; }

    public FileComponent(string name)
    {
        _name = name;
    }

    public virtual void Add(FileComponent component)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(FileComponent component)
    {
        throw new NotImplementedException();
    }

    public virtual void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + _name);
    }
}