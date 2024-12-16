namespace DesignPatters1.BehavioralPattern.Command.WithoutCommand;

public class InvokerN
{
    private ICommandN _onStart;
    private ICommandN _onFinish;
    private ReceiverN _receiver; 

    public void SetOnStart(ICommandN command)
    {
        this._onStart = command;
    }

    public void SetOnFinish(ICommandN command)
    {
        this._onFinish = command;
    }

    public void SetReceiver(ReceiverN receiver)
    {
        this._receiver = receiver;
    }

    public void DoSomethingImportant()
    {
        Console.WriteLine("Invoker: Does anybody want something done before I begin?");
        if (_onStart != null)
        {
            _onStart.Execute();
        }

        Console.WriteLine("Invoker: ...doing something really important...");

        Console.WriteLine("Invoker: Does anybody want something done after I finish?");
        if (_onFinish != null)
        {
            if (_onFinish is ComplexCommandN)
            {
                _onFinish.SetReceiver(_receiver);
            }
            _onFinish.Execute();
        }
    }
}
