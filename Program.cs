using System;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var hwTutorial = new HwTutorialVideo();
            // hwTutorial.HataVerecekMethod();
            // hwTutorial.Carpma();
            // hwTutorial.Booleans();
            // hwTutorial.Expresion();
            // hwTutorial.TurDonusum();
            // hwTutorial.StringParantez();
            // hwTutorial.Tuples();
            // hwTutorial.Operators();
            // hwTutorial.CpnditionalOperator();
            // hwTutorial.NullControl();
            // hwTutorial.IfYapisi();
            // hwTutorial.SwitchYapisi();
            // hwTutorial.WhileDoWhile();
            // hwTutorial.ForLoop();
            // hwTutorial.TupplePattern();
            // hwTutorial.PositonPattern();
            // hwTutorial.WhenUsing();
            // hwTutorial.IsExpersion();
            // hwTutorial.IsTypeControle();

            // var tv1 = new Television();
            // Console.WriteLine("TV \n");
            // tv1.TurnOn();
            // tv1.ChannelChange();
            // tv1.ChannelChange();
            // tv1.TvInfo();
            // tv1.TurnOn();
            // var tv2 = new Television();
            // Console.WriteLine("\n TV2 \n");
            // tv2.TurnOn();
            // tv2.ChannelChange();
            // tv2.TvInfo();
            // tv2.TurnOn();

            // var p1 = new HwStructPoint();
            // var p2 = p1;
            // p1._x = 20;
            // Console.WriteLine($"p1._x : {p1._x} p2._x = {p2._x}");
            // Console.WriteLine(object.ReferenceEquals(p1,p2));
            // Console.WriteLine(object.ReferenceEquals(p1,p1));

            var hwSecond =new HwTutorialSecondClass();
            // hwSecond.SignificantOrderExample();
            // hwSecond.Params(1, 24, 5, 6, 7, 8, 9, 0,1234, 234);
            //_______________________
            // var noktalar = new[] { (45, 5.0),(1.0, 10.0), (123.0,15.0) };
            // var ortalamaUzaklık =  hwSecond.OrtalamaUzaklık((0, 0), noktalar);
            // Console.WriteLine("ortalama uzaklık : " + ortalamaUzaklık);
            //------------------

            // var dprtmn = new HwDepartman();
            // dprtmn[0] = "Bilgi işlem";
            // dprtmn[1] = "Proje yönetimi";
            // dprtmn[2] = "Analiz";
            // dprtmn[3] = "İş Geliştirme";
            // dprtmn[4] = "Destek Sistemleri ";
            // Console.WriteLine(dprtmn[4] +"ve "+ dprtmn[2]);

            
            // var a = 10;
            // var b = 123;
            // hwSecond.Swap<int>(ref a,ref b);
            // //---
            // var c = "Anıl";
            // var d = "Berk";
            // hwSecond.Swap<string>(ref c,ref d);
            //-----
            // var generic = new GenericType<int>(32, "Deneme");
            // var generic2 = new GenericType<string>("adı", "berk");
            
            // hwSecond.ListExample();
            // hwSecond.DictionaryExample();

            // hwSecond.ListCopyed();
            //-----------------------------------------
            var hwThird = new HwTutorialThirdClass();
            
            // hwThird.ArrayTanimlama();
            // hwThird.DuzensizDizi4();
        }
    }
}