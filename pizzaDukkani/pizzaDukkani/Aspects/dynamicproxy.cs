using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace pizzaDukkani.Aspects
{
    class dynamicproxy:IInterceptor
    {
        //kullanılmadı
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
            Console.WriteLine("Interceptor 2");
        }
    }
}
