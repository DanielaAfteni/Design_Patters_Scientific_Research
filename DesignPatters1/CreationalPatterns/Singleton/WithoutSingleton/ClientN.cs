namespace DesignPatters1.CreationalPatterns.Singleton.WithoutSingleton;

public class ClientN
{
    public static void Main()
    {
        Console.WriteLine("Getting first instance...");
        BadSingleton s1 = BadSingleton.GetInstance();

        Console.WriteLine("\nGetting second instance...");
        BadSingleton s2 = BadSingleton.GetInstance();

        if (s1 == s2)
        {
            Console.WriteLine("\nSingleton works, both variables contain the same instance.");
        }
        else
        {
            Console.WriteLine("\nSingleton failed, variables contain different instances.");
        }

        BadSingleton.Instance = new BadSingleton();
        Console.WriteLine("\nManually created a new instance.");

        if (s1 == BadSingleton.Instance)
        {
            Console.WriteLine("Still the same instance (should not happen).");
        }
        else
        {
            Console.WriteLine("Singleton failed, variables now contain different instances.");
        }
    }
}