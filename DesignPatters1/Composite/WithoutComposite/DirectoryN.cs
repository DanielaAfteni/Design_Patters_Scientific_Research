namespace DesignPatters1.Composite.WithoutComposite;

public class DirectoryN
{
    public string Name { get; set; }
    public List<FileN> Files { get; set; } = new();
    public List<DirectoryN> SubDirectories { get; set; } = new();

    public DirectoryN(string name)
    {
        Name = name;
    }

    public void AddFile(FileN file)
    {
        Files.Add(file);
    }

    public void AddDirectory(DirectoryN directory)
    {
        SubDirectories.Add(directory);
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + "Directory: " + Name);

        foreach (var file in Files)
        {
            file.Display(depth + 2);
        }

        foreach (var subDirectory in SubDirectories)
        {
            subDirectory.Display(depth + 2);
        }
    }
}