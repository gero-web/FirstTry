namespace CompreseCodeHumffman.Actions.Interfaces
{
    public interface IAction<T> where T : class
    {
        string Do(T value);
    }
}
