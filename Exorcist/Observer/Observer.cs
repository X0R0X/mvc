using System;
using System.Collections.Generic;
using Exorcist.MVCS;

namespace Exorcist.Observer
{
    public class Observer : IObserver
    {
        private Dictionary<Type, List<Callback<AEvent>>> _listeners;

        public Observer()
        {
            this._listeners = new Dictionary<Type, List<Callback<AEvent>>>();
        }

        public void AddEventListener<T>(Callback<AEvent> callback)
        {
            if (this._listeners.ContainsKey(typeof(T)))
            {
                this._listeners[typeof(T)].Add(callback);
            }
            else
            {
                List<Callback<AEvent>> list = new List<Callback<AEvent>> {callback};
                this._listeners[typeof(T)] = list;
            }
        }

        public void RemoveEventListener<T>(Callback<AEvent> callback)
        {
            if (this._listeners.ContainsKey(typeof(T)))
            {
                List<Callback<AEvent>> list = this._listeners[typeof(T)];
                list.Remove(callback);
                if (list.Count == 0)
                {
                    this._listeners.Remove(typeof(T));
                }
            }
            else
            {
                throw new Exception("Unable to remove callback for " + typeof(T));
            }
        }

        public void DispatchEvent<T>(AEvent e)
        {
            if (this._listeners.ContainsKey(typeof(T)))
            {
                List<Callback<AEvent>> callbacks = this._listeners[typeof(T)];
                foreach (var callback in callbacks)
                {
                    callback.Invoke(e);
                }
            }
        }
    }
}