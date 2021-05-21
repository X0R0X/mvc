namespace Exorcist.MVCS
{
    public class AService
    {
        protected readonly IMessageBus _messageBus;

        protected AService(IMessageBus messageBus)
        {
            _messageBus = messageBus;
        }
    }
}