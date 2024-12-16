namespace DesignPatters1.BehavioralPattern.Command.WithCommand;
public class Client
{
    public static void Main()
    {
        Invoker invoker = new Invoker();
        invoker.SetOnStart(new SimpleCommand("Say Hi!"));
        Receiver receiver = new Receiver();
        invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

        invoker.DoSomethingImportant();
    }
}
