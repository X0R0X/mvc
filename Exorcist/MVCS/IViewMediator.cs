namespace Exorcist.MVCS
{
    public interface IViewMediator<T> where T : IView
    {
        void Register(IController controller, IMessageBus messageBus);

        void Unregister();

        void Update();
    }
}