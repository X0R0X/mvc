namespace Exorcist.MVCS
{
    public interface IModelRegister
    {
        void RegisterModel(AModel model);

        void UnregisterModel(AModel model);

        AModel GetModel<T>();
    }
}