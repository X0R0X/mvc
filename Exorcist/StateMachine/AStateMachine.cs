namespace Exorcist.StateMachine
{
    public abstract class AStateMachine<T> : IStateMachine<T>
    {
        protected T _owner;
        protected IState<T> _state;
        protected bool isIntransition;
        private IState<T> _previousState;

        public virtual void Init(T owner)
        {
            _owner = owner;
        }

        public virtual void ChangeState(IState<T> newState)
        {
            if (_state != null)
            {
                _previousState = _state;
                _state.TransitionTo(() => { EndPreviousStateTransition();});
            }

            _state = newState;
        }


        private void EndPreviousStateTransition()
        {
            _state.Enter(_owner);
        }


        public virtual void Update()
        {
            if (_state!=null && !_state.IsInTransition())
            {
                _state.Update();
            }
        }
    }
}