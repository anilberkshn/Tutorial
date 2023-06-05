using System;
using System.Collections.Generic;

namespace Tutorial.CodeExample
{
    public class HwTutorialSecondClass
    {
        private static int a = b + 20;
        private static int b = 10;
        private static int c = b + 20;


        public void SignificantOrderExample()
        {
            Console.WriteLine($"a:{a} b: {b} c{c}");
        }

        //----------------------------------------------------------------------
        public void OpsiyonelArgumentUsing(string suçlu, string problem)
        {
            // ?????? nasıl yapılabilir tam anlayamadım. 
        }

        //----------------------------------------------------------------------
        public int Params(params int[] sayilar)
        {
            int enBuyukSayi = -1;
            if (sayilar.Length > 0)
            {
                enBuyukSayi = sayilar[0];
            }

            foreach (var sayi in sayilar)
            {
                if (enBuyukSayi < sayi)
                {
                    enBuyukSayi = sayi;
                }
            }

            Console.WriteLine("En Büyük sayı :" + enBuyukSayi);
            return enBuyukSayi;
        }

        //----------------------------------------------------------------------
        public double OrtalamaUzaklık((double X, double Y) ReferansNoktası,
            (double X, double Y)[] noktalar)
        {
            double total = 0;
            for (int i = 0; i < noktalar.Length; ++i)
            {
                total += ReferansUzaklik(noktalar[i]);
            }

            return total / noktalar.Length;


            double ReferansUzaklik((double X, double Y) p)
            {
                return Uzaklik(p, ReferansNoktası);
            }
            // yukarıdakinin daha sade hali aşağıdaki 
            double ReferansUzaklik1((double X, double Y) p)
                =>Uzaklik(p, ReferansNoktası);
            

            double Uzaklik((double X, double Y) p1, (double X, double Y) p2)
            {
                double dx = p1.X - p2.X;
                double dy = p1.Y - p2.Y;

                return Math.Sqrt(dx * dx + dy * dy);
            }
        }

        //----------------------------------------------------------------------
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($" {a}, {b}");

        }

        //----------------------------------------------------------------------
        public void ListExample()
        {
            List<string> names = new List<string>();
            names.Add("Haydar");
            names.Add("Murat");
            names.Add("Yasin");
            names.Add("Veli");

            foreach (var name  in names)
            {
                Console.WriteLine(name);
            }
        }

        //----------------------------------------------------------------------
        public void DictionaryExample()
        {
            var dictionary = new Dictionary<int, string>() {{1,"f"},{2,"g"} };
            Console.WriteLine("ilk dictionary;;");
            foreach (KeyValuePair<int, string> entry in dictionary)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }
            
            
            var dictionary2 = new Dictionary<int, string>()
            {
                {1,"Fatih"},
                {2,"Sultan"},
                {3,"Mehmet"},
                {4,"İstanbul"},
            };
            Console.WriteLine($"\n dictionary2 2.nin üyeleri; ");
            foreach (KeyValuePair<int, string> entry in dictionary2)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }
            
            
        }

        //----------------------------------------------------------------------
        public void ListCopy<T>(List<T> source ,List<T> destination)
        {
           foreach (var obj in source)
            {
                destination.Add(obj);
            }
        }

        public void ListCopyed()
        {
            var list1 = new List<int>();
            list1.Add(2);
            list1.Add(23);
            list1.Add(215);
            list1.Add(12);

            var list2 = new List<int>();
            ListCopy(list1,list2);
            Console.WriteLine("List 2:  "+list2.Count +" Elemanlıdır");
            foreach (var VARIABLE in list2)
            {
                Console.WriteLine(VARIABLE);
            }
        }
        

        //----------------------------------------------------------------------
        public void HazirFonksiyon12()
        {
        }
        //----------------------------------------------------------------------
    }
}