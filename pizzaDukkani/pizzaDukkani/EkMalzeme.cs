using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
using pizzaDukkani.Aspects;

namespace pizzaDukkani
{
    public abstract class EkMalzeme : Pizza
    {
        protected double katkıFiyat = 0;
    }

    public class sucuk : EkMalzeme
    {
        Pizza pizza;

        public sucuk(Pizza yeniPizza)
        {
            pizza = yeniPizza;
            katkıFiyat = 2;
        }

        public override double getFiyat()
        {
            return this.pizza.getFiyat() + katkıFiyat;
        }

        public override string getIsim()
        {
            return this.pizza.getIsim() + ", Ekstra Sucuk";
        }

        
    }
    public class kasar : EkMalzeme
    {
        Pizza pizza;
        public kasar(Pizza yeniPizza)
        {
            pizza = yeniPizza;
            katkıFiyat = 1.5;
        }

        public override double getFiyat()
        {
            return this.pizza.getFiyat() + katkıFiyat;
        }

        public override string getIsim()
        {
            return this.pizza.getIsim() + ", Ekstra Kaşar";
        }
    }
    public class mantar : EkMalzeme
    {
        Pizza pizza;
        public mantar(Pizza yeniPizza)
        {
            pizza = yeniPizza;
            katkıFiyat = 1;
        }

        public override double getFiyat()
        {
            return this.pizza.getFiyat() + katkıFiyat;
        }

        public override string getIsim()
        {
            return this.pizza.getIsim() + ", Ekstra Mantar";
        }
    }

    public class zeytin : EkMalzeme
    {
        Pizza pizza;
        public zeytin(Pizza yeniPizza)
        {
            pizza = yeniPizza;
            katkıFiyat = 1;
        }

        public override double getFiyat()
        {
            return this.pizza.getFiyat() + katkıFiyat;
        }

        public override string getIsim()
        {
            return this.pizza.getIsim() + ", Ekstra Zeytin";
        }
    }
    public class misir : EkMalzeme
    {
        Pizza pizza;
        public misir(Pizza yeniPizza)
        {
            pizza = yeniPizza;
            katkıFiyat = 0.5;
        }

        public override double getFiyat()
        {
            return this.pizza.getFiyat() + katkıFiyat;
        }

        public override string getIsim()
        {
            return this.pizza.getIsim() + ", Ekstra Mısır";
        }
    }
}
