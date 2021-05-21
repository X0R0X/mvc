namespace Exorcist.MVCS
{
    public interface IController
    {
        void RunCommand(ACommand command);
    }
}