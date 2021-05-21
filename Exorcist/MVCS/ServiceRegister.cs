using System;
using System.Collections.Generic;

namespace Exorcist.MVCS
{
    public class ServiceRegister
    {
        private readonly Dictionary<Type, AService> _register;

        public ServiceRegister()
        {
            this._register = new Dictionary<Type, AService>();
        }

        public void RegisterService(AService Service)
        {
            var t = Service.GetType();
            if (this._register.ContainsKey(t))
            {
                throw new Exception("Service for type " + t + " already registered.");
            }
            else
            {
                this._register[t] = Service;
            }
        }

        public void UnregisterService(AService Service)
        {
            var t = Service.GetType();
            if (this._register.ContainsKey(t))
            {
                this._register.Remove(t);
            }
            else
            {
                throw new Exception("Service for type " + t + " not registered.");
            }
        }

        public AService GetService<T>()
        {
            return this._register[typeof(T)];
        }
    }
}