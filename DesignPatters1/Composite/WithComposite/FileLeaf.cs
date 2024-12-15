namespace DesignPatters1.Composite.WithComposite;

public class FileLeaf : FileComponent
{
    public FileLeaf(string name) : base(name) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + "File: " + _name);
    }
}