using System;
using mvc_poc.mvc.utils;

namespace mvc_poc.mvc
{
    public abstract class AModelEvent : AEvent
    {
    }

    public abstract class AViewEvent : AEvent
    {
    }

    public interface IMessageBus
    {
        void AddEventListener<T>(Callback<AEvent> callback);

        void RemoveEventListener<T>(Callback<AEvent> callback);

        void DispatchFromView<T>(AViewEvent e);

        void DispatchFromModel<T>(AModelEvent e);
    }

    public class MessageBus : IMessageBus
    {
        private readonly Observer _observer;

        public MessageBus()
        {
            this._observer = new Observer();
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
            _observer.DispatchEvent<T>(e);
        }

        public void DispatchFromModel<T>(AModelEvent e)
        {
            _observer.DispatchEvent<T>(e);
        }
    }
}