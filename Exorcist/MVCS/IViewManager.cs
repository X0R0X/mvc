namespace Exorcist.MVCS
{
    public interface IViewManager
    {
        void RegisterView(AViewMediator<IView> viewMediator);
        void UnregisterView(AViewMediator<IView> viewMediator);

        void Update();
    }
}