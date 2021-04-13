using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
using pizzaDukkani.Aspects;
using Castle.DynamicProxy;

namespace pizzaDukkani
{
    class Program
    {
        [ExceptionAspect]
        [AcilisAspect]
        static void Main(string[] args)
        {
            PizzaDukkani d1 = yalovaSube.getsube();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Satın almak istediğiniz pizzayı seçiniz:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1-) Bol Malzemos(sucuk,kaşar,biber,pizza sosu)-15TL\n" +
                    "2-) Sosyal Pizza(sucuk,kaşar,mısır,pizza sosu)-13TL\n" +
                    "3-) Vejeteryan Pizza(kaşar,mantar,biber,pizza sosu)-10TL");
                
                while (true)
                {
                    int pizzaSecim = Convert.ToInt32(Console.ReadLine());
                    if (pizzaSecim == 1 || pizzaSecim == 2 || pizzaSecim == 3)
                    {
                        d1.pizzaSiparis(pizzaSecim);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hatalı giriş yaptınız,lütfen tekrar deneyiniz:");
                        continue;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Ekstra malzeme istiyor musunuz?\n 1-)EVET   2-)HAYIR");
               
                while (true)
                {
                    int ekstraOlsunMu = Convert.ToInt32(Console.ReadLine());
                    if (ekstraOlsunMu == 1)
                    {
                        while (ekstraOlsunMu !=2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Eklemek istediğiniz malzemeyi seçiniz:");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("1-)Ekstra Sucuk( 2TL ) 2-)Ekstra Kaşar( 1.5TL ) 3-)Ekstra Mantar( 1TL ) 4-)Ekstra Zeytin( 1TL ) 5-)Ekstra Mısır( 0.5TL )");
                            int malzemeSecim = Convert.ToInt32(Console.ReadLine());
                            if (malzemeSecim == 1 || malzemeSecim == 2 || malzemeSecim == 3 || malzemeSecim == 4 || malzemeSecim == 5)
                            {
                                d1.ekstraSiparis(malzemeSecim);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Eklemek istediğiniz başka birşey var mı?:");
                                Console.WriteLine("1-)Evet 2-)Hayır");
                                ekstraOlsunMu = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Hatalı giriş yaptınız,lüyfen tekrar deneyiniz:");
                                continue;
                            }
                        }
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        d1.SiparisiHazırlama();
                        break;
                    }
                    else if (ekstraOlsunMu == 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        d1.SiparisiHazırlama();
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hatalı giriş yaptınız,lüyfen tekrar deneyiniz:");
                        continue;
                    }
                    break;
                }

                break;
            }

        }
    }
}
