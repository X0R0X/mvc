using System;

namespace Exorcist.StateMachine
{
    public interface IState<T>
    {
        bool IsInTransition();
        void Enter(T owner);
        void Update();
        void TransitionTo(Action action);
    }
}