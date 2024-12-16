namespace DesignPatters1.BehavioralPattern.ChainOfResponsibility.WithChainOfResponsibility;

public interface IHandler
{
    IHandler SetNext(IHandler handler);

    object Handle(object request);
}