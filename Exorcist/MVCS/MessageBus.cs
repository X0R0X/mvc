namespace Exorcist.MVCS
{
    public class MessageBus : IMessageBus
    {
        private readonly Observer.Observer _observer;

        public MessageBus()
        {
            this._observer = new Observer.Observer();
        }

        public void AddEventListener<T>(Callback<AEvent> callback)
        {
            _observer.AddEventListener<T>(callback);
        }

        public void RemoveEventListener<T>(Callback<AEvent> callback)
        {
            _observer.RemoveEventListener<T>(callback);
        }

        public void DispatchFromView<T>(AViewEvent e)
        {
            _observer.DispatchEvent<AViewEvent>(e);
        }

        public void DispatchFromModel<T>(AModelEvent e)
        {
            _observer.DispatchEvent<T>(e);
        }


    }
}