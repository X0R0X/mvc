namespace Exorcist.MVCS
{
    public delegate void Callback<T>(T t) where T : AEvent;
}