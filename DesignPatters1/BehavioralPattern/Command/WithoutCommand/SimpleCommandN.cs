using DesignPatters1.BehavioralPattern.Command.WithCommand;

namespace DesignPatters1.BehavioralPattern.Command.WithoutCommand;

public class SimpleCommandN : ICommandN
{
    private string _payload = string.Empty;

    public SimpleCommandN(string payload)
    {
        this._payload = payload;
    }

    public void Execute()
    {
        Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");
    }

    public void SetReceiver(ReceiverN receiver)
    {
        // No need for this method here, but added for interface conformity.
    }
}