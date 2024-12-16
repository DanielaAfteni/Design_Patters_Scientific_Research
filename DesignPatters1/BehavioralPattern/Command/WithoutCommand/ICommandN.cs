namespace DesignPatters1.BehavioralPattern.Command.WithoutCommand;

public interface ICommandN
{
    void Execute();
    void SetReceiver(ReceiverN receiver);
}