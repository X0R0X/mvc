using System;
using System.Collections.Generic;

namespace mvc_poc.mvc
{
    public interface IViewManager
    {
        void RegisterView(AViewMediator viewMediator);
        void UnregisterView(AViewMediator viewMediator);

        void Update();
    }

    public class ViewManager : IViewManager
    {
        private readonly IController _controller;
        private readonly IMessageBus _messageBus;

        private readonly List<AViewMediator> _viewMediators;

        public ViewManager(IController controller, IMessageBus messageBus)
        {
            _controller = controller;
            _messageBus = messageBus;

            _viewMediators = new List<AViewMediator>();
        }

        public void RegisterView(AViewMediator viewMediator)
        {
            viewMediator.Register(_controller, _messageBus);
            _viewMediators.Add(viewMediator);
        }

        public void UnregisterView(AViewMediator viewMediator)
        {
            viewMediator.Unregister();
            _viewMediators.Remove(viewMediator);
        }

        public void Update()
        {
            foreach (var vm in _viewMediators)
            {
                vm.Update();
            }
        }
    }

    public abstract class AViewMediator
    {
        protected IController _controller;
        protected IMessageBus _messageBus;

        public abstract void Update();

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
    }
}