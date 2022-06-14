using System.Reflection;
using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors;

[AttributeUsage(AttributeTargets.Class|AttributeTargets.Method,AllowMultiple = true,Inherited = true)] 
public abstract class MethodInterceptionBaseAttribute:Attribute,IInterceptor
{
    public int Priority { get; set; }

    public virtual void Intercept(IInvocation invocation)
    {

    }
}
    
//Burada Attributeleri classlarda ve methodlarda kullanabileceiğimizi
// Ve birden fazla yerde kullanabiliyoruz mesela loglama yapıyoruz hem data da
// Hemde bir dosyaya logluyor Attribute dediğimiz şeyler [Buraya kural gelir]
// bu şekilde yazılır İş kurallarını bu şekilde temiz yazabiliriz.
    
    