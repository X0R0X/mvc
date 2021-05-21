namespace Exorcist.MVCS
{
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