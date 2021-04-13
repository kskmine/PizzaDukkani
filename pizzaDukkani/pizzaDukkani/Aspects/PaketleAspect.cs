﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
namespace pizzaDukkani.Aspects
{
    [Serializable]
    class PaketleAspect:OnMethodBoundaryAspect
    {
        public override void OnExit(MethodExecutionArgs args)
        {
            ConsoleProgress progress = new ConsoleProgress();
            progress.ProgressBar(60);
            for (int i = 0; i < 101; i++)
            {
                progress.Update(i);
                System.Threading.Thread.Sleep(50);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPizza hazır. Afiyet olsun.");
        }
    }
}
