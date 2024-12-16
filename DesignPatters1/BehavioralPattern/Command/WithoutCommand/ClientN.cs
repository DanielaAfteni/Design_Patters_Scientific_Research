namespace DesignPatters1.BehavioralPattern.Command.WithoutCommand;

public class ClientN
{
    public static void Main()
    {
        InvokerN invoker = new InvokerN();
        invoker.SetOnStart(new SimpleCommandN("Say Hi!"));

        ReceiverN receiver = new ReceiverN();
        invoker.SetReceiver(receiver);

        ComplexCommandN complexCommand = new ComplexCommandN("Send email", "Save report");
        invoker.SetOnFinish(complexCommand);

        invoker.DoSomethingImportant();
    }
}