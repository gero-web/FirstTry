using CompreseCodeHumffman.Actions.Services;
using CompreseCodeHumffman.Interface;
using CompreseCodeHumffman.Model;
using System.Reflection;

namespace CompreseCodeHumffman.Service
{
    public class ContextService
    {
        public void ContextMethod()
        {
            var assembly = Assembly.GetAssembly(this.GetType())
                                    ?? throw new ArgumentNullException("assembly not found");

            Type typeObject = assembly.GetTypes()
                                      .Where(type => type.Name.Equals(nameof(Subject)))
                                      .FirstOrDefault()
                                      ?? throw new ArgumentNullException("object is null");


            Type typeAction = assembly.GetTypes()
                                      .Where(type => type.Name.Equals(nameof(DescriptionSubjectAction)))
                                      .FirstOrDefault()
                                      ?? throw new ArgumentNullException("object is null");

            var subject = Activator.CreateInstance(typeObject);
            var subjectAction = Activator.CreateInstance(typeAction);

            var typeIExuter = typeof(IExcuter<,>);

            var typeExcuter = AppDomain.CurrentDomain.GetAssemblies()
                      .SelectMany(assembly => assembly.GetTypes())
                      .Where(t => t.GetInterfaces().Any(i => i.Name.Equals(typeIExuter.Name)))
                      .Where(t => t.GetInterfaces().Any(x =>
                            x.IsGenericType && x.GetGenericArguments().Contains(typeObject) &&
                            x.GetGenericArguments().Contains(typeAction)
                      ))
                      .FirstOrDefault();

            var service = Activator.CreateInstance(typeExcuter);
            MethodInfo methodInfo = typeExcuter?.GetMethod("Execute");
            methodInfo.Invoke(service, [subjectAction]);

        }
    }
}
