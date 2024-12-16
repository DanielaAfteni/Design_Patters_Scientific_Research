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

    public string Operation()
    {
        string result = "Facade initializes subsystems:\n";
        result += Subsystem1.Operation1();
        result += Subsystem2.Operation1();
        result += "Facade orders subsystems to perform the action:\n";
        result += Subsystem1.OperationN();
        result += Subsystem2.OperationZ();
        return result;
    }
}