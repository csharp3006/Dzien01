using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonwersjaTypow
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna1 = 10;
            byte zmienna2 = 5;

            zmienna1 = zmienna2;
            zmienna2 = (byte)zmienna1;
            Console.WriteLine("zmienna1=" + zmienna1 + ", zmienna2=" + zmienna2);

            zmienna1 = 257;
            zmienna2 = (byte)zmienna1;
            Console.WriteLine("zmienna1=" + zmienna1 + ", zmienna2=" + zmienna2);

            // 257dec = 00000001 00000001 bin
            // byte   = xxxxxxxx 00000001

            double wartosc1 = -18765.99;
            int wartosc2 = (int)wartosc1;
            Console.WriteLine("wartosc2=" + wartosc2);

            Console.WriteLine("wartosc1=" + wartosc1.ToString());

            // uzycie metod klasy Convert
            wartosc2 = Convert.ToInt32(wartosc1);
            Console.WriteLine("wartosc2=" + wartosc2);

            wartosc2 = Convert.ToInt32("1234567");
            Console.WriteLine("wartosc2=" + wartosc2);

            wartosc1 = Convert.ToDouble("1234567,89");
            Console.WriteLine("wartosc1=" + wartosc1);

            Console.WriteLine("Konwersja do Bool [0]=" +  Convert.ToBoolean(0) );
            Console.WriteLine("Konwersja do Bool [1]=" +  Convert.ToBoolean(1) );
            Console.WriteLine("Konwersja do Bool [10]=" +  Convert.ToBoolean(10) );
            Console.WriteLine("Konwersja do Bool [-10]=" +  Convert.ToBoolean(-10) );


            Console.ReadKey();
        }
    }
}
