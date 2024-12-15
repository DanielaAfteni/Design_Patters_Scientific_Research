namespace DesignPatters1.CreationalPatterns.Singleton.WithoutSingleton;

public class BadSingleton
{
    public BadSingleton() { }

    public static BadSingleton Instance;

    public static BadSingleton GetInstance()
    {
        if (Instance == null)
        {
            Console.WriteLine("Creating a new instance.");
            Instance = new BadSingleton();
        }
        else
        {
            Console.WriteLine("Returning existing instance.");
        }

        return Instance;
    }

    public void SomeBusinessLogic()
    {
        Console.WriteLine("Executing business logic on instance.");
    }
}