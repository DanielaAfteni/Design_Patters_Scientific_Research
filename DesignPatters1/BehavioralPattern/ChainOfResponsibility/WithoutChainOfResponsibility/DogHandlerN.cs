namespace DesignPatters1.BehavioralPattern.ChainOfResponsibility.WithoutChainOfResponsibility
{
    public class DogHandlerN : IHandlerN
    {
        private IHandlerN _next;

        public void SetNext(IHandlerN handler)
        {
            _next = handler;
        }

        public string Handle(string request)
        {
            if (request == "MeatBall")
            {
                return $"Dog: I'll eat the {request}.\n";
            }
            else
            {
                return _next?.Handle(request);
            }
        }
    }
}