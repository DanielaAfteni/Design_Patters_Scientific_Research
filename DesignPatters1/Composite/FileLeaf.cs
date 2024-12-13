namespace DesignPatters1.Composite;

public class FileLeaf : FileComponent
{
    public FileLeaf(string name) : base(name) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + "File: " + _name);
    }
}