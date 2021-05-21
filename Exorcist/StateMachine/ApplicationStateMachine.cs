namespace Exorcist.StateMachine
{
    public class ApplicationStateMachine : AStateMachine<App>
    {
        public override void Init(App owner)
        {
            base.Init(owner);
        }

        public override void ChangeState(IState<App> newState)
        {
            base.ChangeState(newState);
        }

        public override void Update()
        {
            base.Update();
        }
    }
}