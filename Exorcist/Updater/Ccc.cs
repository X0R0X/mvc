using Unity.VisualScripting;
using UnityEngine;

namespace Exorcist.Updater
{
    public class Ccc
    {
    }

    public interface IUpdater
    {
        public void RegisterToEarlyUpdate(AManagedEarlyUpdate managedEarlyUpdate);
        public void RegisterToUpdate(AManagedUpdate managedUpdate);
        public void RegisterToLateUpdate(AManagedLateUpdate managedLateUpdate);
        public void ManagedEarlyUpdate();
        public void ManagedUpdate();
        public void ManagedLateUpdate();
    }


    public interface IManagedEarlyUpdate
    {
        public void ManagedEarlyUpdate();
    }

    public abstract class AManagedEarlyUpdate : MonoBehaviour, IManagedEarlyUpdate
    {
        public AManagedEarlyUpdate next;

        protected virtual void Awake()
        {
            App.Instance.Updater.RegisterToEarlyUpdate(this);
        }

        public virtual void ManagedEarlyUpdate()
        {
        }
    }

    public interface IManagedUpdate
    {
        public void ManagedUpdate();
    }

    public abstract class AManagedUpdate : MonoBehaviour, IManagedUpdate
    {
        private AManagedUpdate next;

        protected virtual void Awake()
        {
            App.Instance.Updater.RegisterToUpdate(this);
        }

        public virtual void ManagedUpdate()
        {
        }
    }

    public interface IManagedLateUpdate
    {
        public void ManagedLateUpdate();
    }

    public abstract class AManagedLateUpdate : MonoBehaviour, IManagedLateUpdate
    {
        private AManagedLateUpdate next;

        protected virtual void Awake()
        {
            App.Instance.Updater.RegisterToLateUpdate(this);
        }

        public virtual void ManagedLateUpdate()
        {
        }
    }

    public abstract class AUpdater : IUpdater
    {
        private AManagedEarlyUpdate _firstEarlyUpdate;
        private AManagedEarlyUpdate _lastEarlyUpdate;
        private AManagedUpdate _firstUpdate;
        private AManagedUpdate _lastUpdate;
        private AManagedLateUpdate _firstLateUpdate;
        private AManagedLateUpdate _lastLateUpdate;

        public void RegisterToEarlyUpdate(AManagedEarlyUpdate managedEarlyUpdate)
        {
        }

        public void RegisterToUpdate(AManagedUpdate managedUpdate)
        {
        }

        public void RegisterToLateUpdate(AManagedLateUpdate managedLateUpdate)
        {
        }

        public void ManagedEarlyUpdate()
        {
        }

        public void ManagedUpdate()
        {
        }

        public void ManagedLateUpdate()
        {
        }
    }
}