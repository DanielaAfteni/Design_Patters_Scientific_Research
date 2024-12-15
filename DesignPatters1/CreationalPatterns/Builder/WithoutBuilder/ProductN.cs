namespace DesignPatters1.CreationalPatterns.Builder.WithoutBuilder;

public class ProductN
{
    private List<string> _parts = new List<string>();

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public string ListParts()
    {
        return "Product parts: " + string.Join(", ", _parts);
    }
}