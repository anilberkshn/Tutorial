using System;
using System.Globalization;

namespace Tutorial
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

        //----------------------------------------------------------------------
        public void HazirFonksiyon3()
        {
        }
        //----------------------------------------------------------------------

        //----------------------------------------------------------------------
        public void HazirFonksiyon4()
        {
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