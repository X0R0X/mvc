namespace Exorcist.MVCS
{


    public interface IMessageBus
    {
        void AddEventListener<T>(Callback<AEvent> callback);

        void RemoveEventListener<T>(Callback<AEvent> callback);

        void DispatchFromView<T>(AViewEvent e);

        void DispatchFromModel<T>(AModelEvent e);
    }


}