namespace DesignPatters1.StructuralPatterns.Composite.WithComposite;

public class DirectoryComposite : FileComponent
{
    private List<FileComponent> _children = new();
    public DirectoryComposite(string name) : base(name) { }

    public override void Add(FileComponent component)
    {
        _children.Add(component);
    }

    public override void Remove(FileComponent component)
    {
        _children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + "Directory: " + _name);
        foreach (FileComponent component in _children)
        {
            component.Display(depth + 2);
        }
    }
}
