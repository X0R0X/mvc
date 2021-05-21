using System;
using System.Collections.Generic;

namespace Exorcist.MVCS
{
    public class ModelRegister : IModelRegister
    {
        private readonly Dictionary<Type, AModel> _register;

        public ModelRegister()
        {
            this._register = new Dictionary<Type, AModel>();
        }

        public void RegisterModel(AModel model)
        {
            var t = model.GetType();
            if (this._register.ContainsKey(t))
            {
                throw new Exception("Model for type " + t + " already registered.");
            }
            else
            {
                this._register[t] = model;
            }
        }

        public void UnregisterModel(AModel model)
        {
            var t = model.GetType();
            if (this._register.ContainsKey(t))
            {
                this._register.Remove(t);
            }
            else
            {
                throw new Exception("Model for type " + t + " not registered.");
            }
        }

        public AModel GetModel<T>()
        {
            return this._register[typeof(T)];
        }
    }
}