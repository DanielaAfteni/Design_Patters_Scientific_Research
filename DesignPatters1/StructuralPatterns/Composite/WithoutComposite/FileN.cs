namespace DesignPatters1.StructuralPatterns.Composite.WithoutComposite;

public class FileN
{
    public string Name { get; set; }

    public FileN(string name)
    {
        Name = name;
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + "File: " + Name);
    }
}