using DesignPatters1.BehavioralPattern.ChainOfResponsibility.WithChainOfResponsibility;

namespace DesignPatters1.BehavioralPattern.ChainOfResponsibility.WithoutChainOfResponsibility;

public class SquirrelHandlerN : IHandlerN
{
    private IHandlerN _next;

    public void SetNext(IHandlerN handler)
    {
        _next = handler;
    }

    public string Handle(string request)
    {
        if (request == "Nut")
        {
            return $"Squirrel: I'll eat the {request}.\n";
        }
        else
        {
            return _next?.Handle(request);
        }
    }
}