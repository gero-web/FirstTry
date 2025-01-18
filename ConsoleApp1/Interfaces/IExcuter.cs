using CompreseCodeHumffman.Actions.Interfaces;

namespace CompreseCodeHumffman.Interface
{
    public interface IExcuter<T, UAction> 
    {
       void Execute(UAction action);
    }
}
