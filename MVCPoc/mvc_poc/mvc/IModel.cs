using mvc_poc.mvc.utils;

namespace mvc_poc.mvc
{
    public abstract class AModel : Observer
    {
        protected readonly IMessageBus _messageBus;

        protected AModel(IMessageBus messageBus)
        {
            _messageBus = messageBus;
        }
    }
}