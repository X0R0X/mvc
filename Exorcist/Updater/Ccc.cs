using Unity.VisualScripting;
using UnityEngine;

namespace Exorcist.Updater
{
    public class Ccc
    {
    }

    public interface IManagedEarlyUpdate
    {
        public void ManagedEarlyUpdate();
    }


    public interface IManagedUpdate
    {
        public void ManagedUpdate();
    }



    public interface IManagedLateUpdate
    {
        public void ManagedLateUpdate();
    }


    public class LinkedListMember<T>
    {
        private T previous;
        private T next;
        private T value;
    }

    public class ManagedMonoBehavior : MonoBehaviour
    {


        protected virtual void Awake()
        {
            if (this is IManagedUpdate)
            {
                App.Instance.Updater.Register<IManagedUpdate>(this);
            }
            if (this is IManagedEarlyUpdate)
            {
                App.Instance.Updater.Register<IManagedEarlyUpdate>(this);
            }
            if (this is IManagedLateUpdate)
            {
                App.Instance.Updater.Register<IManagedLateUpdate>(this);
            }
        }
    }

    public abstract class AUpdater : MonoBehaviour
    {
        private LinkedListMember<IManagedEarlyUpdate> _firstEarlyUpdate;
        private LinkedListMember<IManagedEarlyUpdate> _lastEarlyUpdate;
        private LinkedListMember<IManagedUpdate> _firstUpdate;
        private LinkedListMember<IManagedUpdate> _lastUpdate;
        private LinkedListMember<IManagedLateUpdate> _firstLateUpdate;
        private LinkedListMember<IManagedLateUpdate> _lastLateUpdate;

        public void Register<T>(T updatedObject)
        {
        }
        
        public void Unregister<T>(T updatedObject)
        {
        }
        

        protected void ManagedEarlyUpdate()
        {
        }

        protected void ManagedUpdate()
        {
        }

        protected void ManagedLateUpdate()
        {
        }
    }
}