namespace DesignPatters1.BehavioralPattern.Command.WithoutCommand;

public class ComplexCommandN : ICommandN
{
    private ReceiverN _receiver;
    private string _a;
    private string _b;

    public ComplexCommandN(string a, string b)
    {
        this._a = a;
        this._b = b;
    }

    public void SetReceiver(ReceiverN receiver)
    {
        this._receiver = receiver;
    }

    public void Execute()
    {
        if (_receiver == null)
        {
            throw new InvalidOperationException("Receiver not set!");
        }
        Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
        _receiver.DoSomething(this._a);
        _receiver.DoSomethingElse(this._b);
    }
}