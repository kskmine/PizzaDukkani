using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace pizzaDukkani.Aspects
{
    [Serializable]
    class AcilisAspect:OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\n\n\t\t\tDominoz Pizzaya Hoş Geldiniz.");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
