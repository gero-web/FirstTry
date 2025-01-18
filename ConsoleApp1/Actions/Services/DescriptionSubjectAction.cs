using CompreseCodeHumffman.Actions.Interfaces;
using CompreseCodeHumffman.Model;

namespace CompreseCodeHumffman.Actions.Services
{
    public class DescriptionSubjectAction : IAction<Subject>
    { 
        public string Do(Subject value)
        {
            Console.WriteLine(value.Description);
            return value.Description;
        }
    }
}
