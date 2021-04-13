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
    class PizzaSecimAspect : MethodInterceptionAspect
    {
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            Pizza pizza;
            var arguments = args.Arguments;
            if ((int)arguments[0] == 1)
            {
                pizza = new bolmalzemosPizza();
                args.ReturnValue = pizza;
            }
            else if ((int)arguments[0] == 2)
            {
                pizza = new sosyalPizza();
                args.ReturnValue = pizza;
            }
            else if ((int)arguments[0] == 3)
            {
                pizza = new vejeteryanPizza();
                args.ReturnValue = pizza;
            }
        }
    }
}
