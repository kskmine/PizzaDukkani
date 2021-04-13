using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
using pizzaDukkani.Aspects;

namespace pizzaDukkani
{
    public abstract class PizzaDukkani
    {
        protected Pizza pizzaOrnek;

        [SecimAspect]
        public virtual void pizzaSiparis(int tip)
        {           
            Pizza p = this.pizzaYap(tip);
            pizzaOrnek = p;
        }
        [SecimAspect]
        public virtual void ekstraSiparis(int tip)
        {
            Pizza p = this.ekstraEkle(tip);
            pizzaOrnek = p;
        }

        public void SiparisiHazırlama()
        {
            pizzaOrnek.hazirla();
            pizzaOrnek.pisir();
            pizzaOrnek.kes();
            pizzaOrnek.paketle();
            Console.WriteLine(string.Format("{0} - {1}TL", pizzaOrnek.getIsim(), pizzaOrnek.getFiyat()));
        }
        protected abstract Pizza pizzaYap(int tip);
        protected abstract Pizza ekstraEkle(int tip);
    }


    public class yalovaSube : PizzaDukkani
    {
        private yalovaSube(){ }
        private static yalovaSube uniqueInstance = new yalovaSube();
        public static yalovaSube getsube()
        {
            return uniqueInstance;
        }
        [PizzaSecimAspect]
        protected override Pizza pizzaYap(int tip)
        {
            //if (tip == 1)
            //{
            //    pizzaOrnek = new bolmalzemosPizza();
            //}
            //else if (tip == 2)
            //{
            //    pizzaOrnek = new sosyalPizza();
            //}
            //else if (tip == 3)
            //{
            //    pizzaOrnek = new vejeteryanPizza();
            //}

            return pizzaOrnek;
        }
        [PizzaSecimAspect]
        protected override Pizza ekstraEkle(int tip)
        {
            if (tip == 1)
            {
                pizzaOrnek = new sucuk(pizzaOrnek);
            }
            else if (tip == 2)
            {
                pizzaOrnek = new kasar(pizzaOrnek);
            }
            else if (tip == 3)
            {
                pizzaOrnek = new mantar(pizzaOrnek);
            }
            else if (tip == 4)
            {
                pizzaOrnek = new zeytin(pizzaOrnek);
            }
            else if (tip == 5)
            {
                pizzaOrnek = new misir(pizzaOrnek);
            }
            return pizzaOrnek;
        }


    }


}
