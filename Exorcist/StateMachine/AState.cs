using System;

namespace Exorcist.StateMachine
{
    public abstract class AState<T> : IState<T>
    {
        private T _owner;
        private bool _isInTransition;
        private Action exitAction;
        public bool IsInTransition()
        {
            return _isInTransition;
        }

        public virtual void Enter(T owner)
        {
            _owner = owner;
            _isInTransition = true;
        }

        public virtual void Update()
        {
        }

        public void TransitionTo(Action action)
        {
            exitAction = action;
            
            
        }
    }
}