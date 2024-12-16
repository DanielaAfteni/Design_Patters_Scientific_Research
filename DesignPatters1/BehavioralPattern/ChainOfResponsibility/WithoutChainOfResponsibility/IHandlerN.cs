namespace DesignPatters1.BehavioralPattern.ChainOfResponsibility.WithoutChainOfResponsibility;

public interface IHandlerN
{
    void SetNext(IHandlerN handler);
    string Handle(string request);
}