using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
using pizzaDukkani;

namespace pizzaDukkani.Aspects
{
    [Serializable]
    class SecimAspect : OnMethodBoundaryAspect
    {

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.WriteLine("Seçiminiz Yapılmıştır.Lütfen ekstra malzeme seçmek istiyorsanız belirtiniz.");
        }
    }
}
