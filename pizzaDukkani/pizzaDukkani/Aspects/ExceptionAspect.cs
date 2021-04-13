using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace pizzaDukkani.Aspects
{
    [Serializable]
    class ExceptionAspect:OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            args.FlowBehavior = FlowBehavior.Continue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\n\t\t\tPROGRAM BİR HATAYLA KARŞILAŞTI LÜTFEN DAHA SONRA TEKRAR DENEYİNİZ !!!");
           
        }
    }
}
