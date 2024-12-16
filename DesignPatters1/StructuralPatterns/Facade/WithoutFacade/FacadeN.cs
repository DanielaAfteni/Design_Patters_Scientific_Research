namespace DesignPatters1.StructuralPatterns.Facade.WithoutFacade;

public class FacadeN
{
    public Subsystem1N Subsystem1 { get; set; }
    public Subsystem2N Subsystem2 { get; set; }

    public FacadeN()
    {
        Subsystem1 = new Subsystem1N();
        Subsystem2 = new Subsystem2N();
    }

    public void Operation()
    {
        Console.WriteLine("Facade initializes subsystems directly:");
        Subsystem1.OperationA();
        Subsystem2.OperationX();

        Console.WriteLine("Facade orders subsystems to perform actions:");
        Subsystem1.OperationB();
        Subsystem2.OperationY();
    }
}