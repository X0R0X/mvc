namespace Exorcist.MVCS
{
    public interface IServiceRegister
    {
        void RegisterService(AService service);

        void UnregisterService(AService service);

        AModel GetService<T>();
    }
}