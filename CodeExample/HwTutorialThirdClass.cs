using System;
using System.Collections;
using System.Collections.Generic;

namespace Tutorial.CodeExample
{
    public class HwTutorialThirdClass
    {
        
        //----------------------------------------------------------------------
        public void ArrayTanimlama()
        {
            var calismagunleri = new string[5];
            calismagunleri[0] = "Pazartesi";
            calismagunleri[1] = "Sali";
            calismagunleri[2] = "Çarşamba";
            calismagunleri[3] = "Perşembe";
            calismagunleri[4] = "Cuma";

            foreach (var VARIABLE in calismagunleri)
            {
                Console.WriteLine(VARIABLE);
            }

            string[] workDays = { "Pazartes", "Sali", "Çarşamba", "Perşembe", "Cuma" };

            foreach (var VARIABLE in workDays)
            {
                Console.WriteLine(VARIABLE);
            }
        }
        //----------------------------------------------------------------------
        public void DuzensizDizi4()  //Düzenli dizi içine düzensiz dizi tanımlama
        {
            int[][,] duzensizDizi4 = new int [3][,]
            {
                new int[,]{{1,3},{5,7}},
                new int[,]{{2,5},{2,3},{8,9}},
                new int[,]{{1,4},{1,7},{109,198},{192,124}}
            };
            foreach (var row in duzensizDizi4)
            {
                foreach (var col in row)
                {
                    Console.Write(col + " ");
                }

                Console.Write("\n");
            }
        }
        //----------------------------------------------------------------------
        public void ListCountAndCapacity()
        {
            var numbers = new List<int>();
            numbers.Add(1) ;
            numbers.Add(2) ;
            numbers.Add(3) ;
            numbers.Add(4) ;
            Console.WriteLine("Capacity Is: " + numbers.Capacity);
            Console.WriteLine("Count Is: " + numbers.Count);

            numbers.Add(5) ;
            numbers.Add(6) ;
            Console.WriteLine("Capacity Is: " + numbers.Capacity);
            Console.WriteLine("Count Is: " + numbers.Count);

            Console.WriteLine(numbers.Contains(4));
            Console.WriteLine("silmeden önce");
            int p1 = 0;
            foreach (var k in numbers)
            {
                Console.Write("index {0}: ", p1 ); 
                Console.WriteLine(k);
                p1++;

            }
        }
        //----------------------------------------------------------------------

        //----------------------------------------------------------------------
        public class Market
        {
            public string ProductName { get; set; }
        }
        public class ProductCollection : IEnumerable
        {
            private Market[] _products;

            public ProductCollection(Market[] products)
            {
                _products = products;
            }

            public IEnumerator GetEnumerator()
            {
            return new ProductEnumator(_products);
            }
        }
        public class ProductEnumator : IEnumerator
        {
            private Market[] _products;
            private int _index = -1;

            public ProductEnumator(Market[] products)
            {
                _products = products;
            }

            public bool MoveNext()
            {
                _index++;
                return (_index < _products.Length);
            }

            public void Reset()
            {
                this._index = -1; 
            }

            public object Current { get; }
        }
        //----------------------------------------------------------------------
        //----------------------------------------------------------------------
        public void HazirFonksiyon5()
        {
        }
        //----------------------------------------------------------------------

        //----------------------------------------------------------------------
        public void HazirFonksiyon6()
        {
        }
        //----------------------------------------------------------------------

        //----------------------------------------------------------------------
        public void HazirFonksiyon7()
        {
        }
        //----------------------------------------------------------------------
        public void HazirFonksiyon8()
        {
        }
        //----------------------------------------------------------------------

    }
}