namespace mvc_poc.mvc
{
    public abstract class ACommand
    {
        protected IModelRegister _modelRegister;
        protected IController _controller;

        public abstract void Execute();

        public void InjectModelRegister(IModelRegister modelRegister)
        {
            this._modelRegister = modelRegister;
        }
    }

    public interface IController
    {
        void RunCommand(ACommand command);
    }

    public class Controller : IController
    {
        private readonly IModelRegister _modelRegister;

        public Controller(IModelRegister modelRegister)
        {
            _modelRegister = modelRegister;
        }

        public void RunCommand(ACommand command)
        {
            command.InjectModelRegister(this._modelRegister);
            command.Execute();
        }
    }
}