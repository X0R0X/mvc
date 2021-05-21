namespace Exorcist.MVCS
{
    public abstract class AViewMediator<T> : IViewMediator<T> where T : IView
    {
        protected IController _controller;
        protected IMessageBus _messageBus;
        protected T _view;

        public AViewMediator(T view)
        {
            _view = view;
        }

        public virtual void Register(IController controller, IMessageBus messageBus)
        {
            _controller = controller;
            _messageBus = messageBus;
        }

        public virtual void Unregister()
        {
            _controller = null;
            _messageBus = null;
        }

        public abstract void Update();
    }
}