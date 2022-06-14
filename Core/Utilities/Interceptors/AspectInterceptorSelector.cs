using System.Reflection;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors;

    public class AspectInterceptorSelector:IInterceptorSelector   //Burada attributeların classlara ve methodlara eklenebildiğini ayarlıyoruz. Bunların hepsi Autofacten türetilmiştir.
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
            //classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger))); Bu bütün methodlara classlara loglama ekliyor Goat!

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
