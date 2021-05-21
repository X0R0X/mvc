namespace Exorcist.StateMachine
{
    public interface IStateMachine<T>
    {
        void Init(T owner);
        void ChangeState(IState<T> newState);
        void Update();
    }
}