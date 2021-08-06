using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Interceptor;
using Core.CrossCutingConcern.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching
{
   public class CacheAspect : MethodInterception

    {

       private int _duration;
       private ICacheManager _cacheManager;

       public CacheAspect(int duration = 60)
       {
           _duration = duration;
           _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
       }

       public override void Incercept(IInvocation iInvocation)
       {
           var methodName = string.Format($"{iInvocation.Method.ReflectedType.FullName}.{iInvocation.Method.Name}");
           var arguments = iInvocation.Arguments.ToList();
           var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";
           if (_cacheManager.IsAdd(key))
           {
               iInvocation.ReturnValue = _cacheManager.Get(key);
               return;
           }
           iInvocation.Proceed();
           _cacheManager.Add(key, iInvocation.ReturnValue, _duration);
       }
    }
   }
}
