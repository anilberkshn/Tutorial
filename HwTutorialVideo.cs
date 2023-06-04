using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic.CompilerServices;

namespace Tutorial
{
    public class HwTutorialVideo
    {
        // void BırMethod()
        // {
        //     int buHataVerecek = 7;
        // }
        //
        // public void HataVerecekMethod()
        // {
        //     //int buHataVerecek = 7; // bir method scope daki başka scope da kullanılamaz
        //     Console.WriteLine(buHataVerecek) ;
        // }
        //----------------------------------------------------------------------
        public void Carpma()
        {
            int a = 7;
            int b = 10;
            int d;
            d = a * b;
            Console.WriteLine($"sonuc = {d}");
        }

        //----------------------------------------------------------------------
        // public void Debug() // debug yapısıyla derleme durumu //todo: #if else yapısı kullanımı değiştimi? eskiden #if şeklinde mi kullanılıyordu
        // {
        //     if (Debug())
        //     {
        //     Console.WriteLine("işlem başlatılıyor");
        //         
        //     }
        //     else ()
        //     {
        //         
        //     }
        //     {
        //     işlemigerçekleştir 
        //         
        //     }
        //     
        // }
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        public void Expresion()
        {
            int sayi;
            Console.WriteLine(sayi = 123);
            Console.WriteLine(sayi);
            int x, y;
            x = y = 0;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        //----------------------------------------------------------------------
        // public void Yonergeler()
        // {
        //     #region MyRegion
        //     #endregion
        //     #pragma warning disable // derleyici 
        // //    #error . NET Standardı bu kaynak için desteklenmemektedir.
        //     #warning 
        // }
        // //----------------------------------------------------------------------
        public void TurDonusum()
        {
            int i = 7;
            double di = i;
            Console.WriteLine(i / 5);
            Console.WriteLine(di / 5);
            Console.WriteLine(i / 5.2);
        }
        //----------------------------------------------------------------------


        public void Booleans()
        {
            bool check = true;

            while (check)
            {
                Console.WriteLine("while çalıştı");
                check = false;
            }

            int number = 20;
            bool control = true;
            if (control)
            {
                Console.WriteLine(number);
            }
        }

        //----------------------------------------------------------------------
        public void StringParantez()
        {
            int perkg = 4;
            int kg = 10;
            string name = "patates";
            string msg = $"{kg} kg {name} fiyatı = {kg * perkg} TL";
            Console.WriteLine(msg);

            string ex1 = "Serkan \n kutlu";
            string ex2 = @"Serkan \n kutlu";
            Console.WriteLine(ex1);
            Console.WriteLine("---");
            Console.WriteLine(ex2);
        }

        //----------------------------------------------------------------------
        public void Tuples()
        {
            (int boy, double kilo) fiz = (175, 80.3);
            int height = fiz.boy;
            double kilo = fiz.kilo; // isimler aynı olabilir. 
            Console.WriteLine($"{height} boyu  {kilo} kilosu    ");
        }

        //----------------------------------------------------------------------
        public void Operators()
        {
            int a = 20;
            int b = 30;
            if (a >= 11 && ++b == 30)
            {
                Console.WriteLine("if çalıştı");
            }

            Console.WriteLine($"a:{a} b:{b}");
            Console.WriteLine("-------------------------");
            if (a >= 11 || ++b == 30)
            {
                Console.WriteLine("if çalıştı");
            }

            Console.WriteLine($"a:{a} b:{b}");
        }
        //----------------------------------------------------------------------


        //----------------------------------------------------------------------

        public void CpnditionalOperator()
        {
            string name = "serkan";
            int chCount = name == null ? 0 : name.Length;
            Console.WriteLine(chCount);
            Console.WriteLine("-----------");

            int x = 10;
            int y = 20;
            Goster(x > y ? x : y, 3, 4);
        }

        public void Goster(int x, int y, int z)
        {
            Console.WriteLine($"x:{x}, y :{y}, z:{z}");
        }
        //----------------------------------------------------------------------

        public void NullControl()
        {
            string name = null;
            string name2 = name ?? "name is null string";
            Console.WriteLine(name2);
            Console.WriteLine("-----");
            string name3 = "serkan";
            int count = name3?.Length ?? 0;
            Console.WriteLine(count);
        }
        //----------------------------------------------------------------------

        public void IfYapisi()
        {
            double kilo = 90;
            double boy = 1.90;
            double index = kilo / Math.Pow(boy, 2);
            Console.WriteLine($"Vucut kitle endeksi : {index:f2}");
            if (index < 18.5)
            {
                Console.WriteLine("zayif");
            }
            else if (index >= 18.5 && index <= 24.99)
            {
                Console.WriteLine("ideal kilo");
            }
            else if (index >= 25 && index <= 29.9)
            {
                Console.WriteLine("kilolu");
            }
            else if (index >= 30 && index <= 39.9)
            {
                Console.WriteLine("Obez");
            }
            else if (index >= 40)
            {
                Console.WriteLine("ileri derece obez");
            }
            else
            {
                Console.WriteLine("Belirlenemedi");
            }
        }

        //----------------------------------------------------------------------
        public void SwitchYapisi()
        {
            int gun = 3;

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("sali");
                    break;
                case 3:
                    Console.WriteLine("çarşamba");
                    break;
                case 4:
                    Console.WriteLine("perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma ");
                    break;
                default:
                    Console.WriteLine("Gün bulunamadı");
                    break;
            }
        }

        //----------------------------------------------------------------------
        public void WhileDoWhile()
        {
            Random randomNumber = new Random();
            int number = 0;
            while (number != 7)
            {
                number = randomNumber.Next(10);
                Console.WriteLine($"üretilen : {number}");
            }

            Console.WriteLine("------");
            int number2 = 7; //Buna rağmen döngüye girer
            do
            {
                number2 = randomNumber.Next(10);
                Console.WriteLine($"üretilen number2  : {number2}");
            } while (number2 != 7);
        }

        //----------------------------------------------------------------------
        public void ForLoop()
        {
            string name = "Anil Berk ";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }

        //----------------------------------------------------------------------
        public void TupplePattern()
        {
            (int age, string name) tp1 = (28, "Anil");
            switch (tp1)
            {
                case (28, "Anil"):
                    Console.WriteLine("burada");
                    break;
                case (1, "şahin"):
                    Console.WriteLine("burada 2");
                    break;
            }
        }

        //----------------------------------------------------------------------
        public void PositonPattern()
        {
            (int a, double y) tp1 = (10, 10.2);
            switch (tp1)
            {
                case (int a, double y):
                    Console.WriteLine("burada position");
                    break;
            }
        }

        //----------------------------------------------------------------------
        public void PropertyPattern()
        {
            string name = "Anıl Berk ";
            switch (name)
            {
                case string { Length: 10 }:
                    Console.WriteLine("propertypattern");
                    break;
            }
        }

        //----------------------------------------------------------------------
        public void WhenUsing()
        {
            (int no1, int no2 ) tuple1 = (2, 2);
            Console.WriteLine(rmo2(tuple1));

            string rmo((int x, int y) tuple)
            {
                switch (tuple)
                {
                    case (int x, int y) when x < y: return "1";
                    case (int x, int y) when x > y: return "2";
                    default: return "3";
                }
            }


            string rmo2((int x, int y) tuple)
            {
                Console.WriteLine("2.yöntem----");
                return tuple switch
                {
                    (int x, int y) when x < y => "1",
                    (int x, int y) when x > y => "2",
                    _ => "3"
                };
            }
        }

        //----------------------------------------------------------------------
        public void IsExpersion()
        {
            int number = 25;
            if (number is int) //Number is integer
            {
                Console.WriteLine("number is integer");
            }
        }

        //----------------------------------------------------------------------
        public void IsTypeControle()
        {
            (int XI, int x2) tpl = (10, 15);
            if (tpl is (int a, int b))
            {
                Console.WriteLine($"a:{a}, b: {b}");
            }
        }

        //----------------------------------------------------------------------
        
    }
}