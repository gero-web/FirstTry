using CompreseCodeHumffman.Actions.Services;
using CompreseCodeHumffman.Interface;
using CompreseCodeHumffman.Model;

namespace CompreseCodeHumffman.Service
{
    public class SubjectService : IExcuter<Subject, DescriptionSubjectAction>
    {
        public void Execute(DescriptionSubjectAction action)
        {
            var subject = new Subject();
            action.Do(subject);
        }
    }
}
