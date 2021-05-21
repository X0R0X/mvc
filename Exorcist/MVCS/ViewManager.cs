using System.Collections.Generic;

namespace Exorcist.MVCS
{
    public class ViewManager : IViewManager
    {
        private readonly IController _controller;
        private readonly IMessageBus _messageBus;

        private readonly List<AViewMediator<IView>> _viewMediators;

        class ViewMediator
        {
            private IView view;
            private AViewMediator<IView> viewMediator;
        }

        public ViewManager(IController controller, IMessageBus messageBus)
        {
            _controller = controller;
            _messageBus = messageBus;

            _viewMediators = new List<AViewMediator<IView>>();
        }


        public void RegisterView(AViewMediator<IView> viewMediator)
        {
            viewMediator.Register(_controller, _messageBus);
            _viewMediators.Add(viewMediator);
        }

        public void UnregisterView(AViewMediator<IView> viewMediator)
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
}