namespace DesignPatters1.StructuralPatterns.Composite.WithComposite;

public class Client
{
    public static void Main()
    {
        FileComponent rootDirectory = new DirectoryComposite("RootDirectory");
        FileComponent file1 = new FileLeaf("File1.txt");
        FileComponent subDirectory = new DirectoryComposite("SubDirectory");
        FileComponent file2 = new FileLeaf("File2.txt");
        FileComponent file3 = new FileLeaf("File3.txt");

        rootDirectory.Add(file1);
        rootDirectory.Add(subDirectory);
        subDirectory.Add(file2);
        subDirectory.Add(file3);

        rootDirectory.Display(1);
    }
}
