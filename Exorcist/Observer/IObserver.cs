using Exorcist.MVCS;

namespace Exorcist.Observer
{
    public interface IObserver
    {
        void AddEventListener<T>(Callback<AEvent> callback);

        void RemoveEventListener<T>(Callback<AEvent> callback);

        void DispatchEvent<T>(AEvent e);
    }
}