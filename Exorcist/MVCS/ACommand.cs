namespace Exorcist.MVCS
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
}