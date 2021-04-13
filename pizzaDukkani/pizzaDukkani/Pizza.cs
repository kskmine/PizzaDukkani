using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
using pizzaDukkani.Aspects;

namespace pizzaDukkani
{
    public abstract class Pizza
    {
        protected string isim = "isimsiz";
        protected double fiyat = 0;
        public virtual string getIsim()
        {
            return isim;
        }

        public virtual double getFiyat()
        {
            return fiyat;
        }

        [ProgressBarAspect]
        public virtual void hazirla()
        {
            Console.WriteLine("Pizza hazırlanıyor.");
            Console.ForegroundColor = ConsoleColor.Green;
            //ConsoleProgress progress = new ConsoleProgress();
            //progress.ProgressBar(60);
            //for (int i = 0; i < 101; i++)
            //{
            //    progress.Update(i);
            //    System.Threading.Thread.Sleep(50);
            //}
        }
        [ProgressBarAspect]
        public virtual void pisir()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPizza pisiriliyor.");
            Console.ForegroundColor = ConsoleColor.Green;
            //ConsoleProgress progress = new ConsoleProgress();
            //progress.ProgressBar(60);
            //for (int i = 0; i < 101; i++)
            //{
            //    progress.Update(i);
            //    System.Threading.Thread.Sleep(50);
            //}
        }
        [ProgressBarAspect]
        public virtual void kes()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPizza kesiliyor.");
            Console.ForegroundColor = ConsoleColor.Green;
            //ConsoleProgress progress = new ConsoleProgress();
            //progress.ProgressBar(60);
            //for (int i = 0; i < 101; i++)
            //{
            //    progress.Update(i);
            //    System.Threading.Thread.Sleep(50);
            //}
        }
        [PaketleAspect]
        public virtual void paketle()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPizza paketleniyor.");
            Console.ForegroundColor = ConsoleColor.Green;
            //ConsoleProgress progress = new ConsoleProgress();
            //progress.ProgressBar(60);
            //for (int i = 0; i < 101; i++)
            //{
            //    progress.Update(i);
            //    System.Threading.Thread.Sleep(50);
            //}
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("\nPizza hazır. Afiyet olsun.");

        }
    }

    public class bolmalzemosPizza : Pizza
    {
        [ProgressBarAspect]
        public override void hazirla()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bolmalzemos pizza hazırlanıyor.");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public bolmalzemosPizza()
        {
            isim = "Bolmalzemos Pizza";
            fiyat = 15;
        }
       
    }

    public class sosyalPizza : Pizza
    {
        [ProgressBarAspect]
        public override void hazirla()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Sosyal pizza hazırlanıyor.");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public sosyalPizza()
        {
            isim = "Sosyal Pizza";
            fiyat = 13;
        }

    }
    public class vejeteryanPizza : Pizza
    {
        [ProgressBarAspect]
        public override void hazirla()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Vegan pizza hazırlanıyor.");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public vejeteryanPizza()
        {
            isim = "Vegan Pizza";
            fiyat = 10;
        }

    }

}

