namespace Exorcist.MVCS
{
    public abstract class AModel
    {
        protected readonly IMessageBus _messageBus;

        protected AModel(IMessageBus messageBus)
        {
            _messageBus = messageBus;
        }
    }
}