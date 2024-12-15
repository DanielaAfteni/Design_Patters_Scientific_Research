namespace DesignPatters1.StructuralPatterns.Composite.WithoutComposite;

public class ClientN
{
    public static void Main()
    {
        DirectoryN rootDirectory = new DirectoryN("RootDirectory");
        FileN file1 = new FileN("File1.txt");
        DirectoryN subDirectory = new DirectoryN("SubDirectory");
        FileN file2 = new FileN("File2.txt");
        FileN file3 = new FileN("File3.txt");

        rootDirectory.AddFile(file1);
        rootDirectory.AddDirectory(subDirectory);
        subDirectory.AddFile(file2);
        subDirectory.AddFile(file3);

        rootDirectory.Display(1);
    }
}
