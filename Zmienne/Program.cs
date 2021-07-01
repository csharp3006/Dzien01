using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * komentarz
             * wielolinijkowy
             */
            StringExamples();

            //int zmienna1 = 10; // zmienna typu całkowitego
            //byte wiekUzytkownika = 29;
            //float cena = 123.45f;
            //double zarobki = 99999.99;
            //decimal dlugPubliczny = 45353535355645456.55m;

            //bool czyPelnoletni = false; czyPelnoletni = true;

            //Int32 x = 1234;
            //UInt16 y = 987;

            //char znak = 'a';
            //znak = 'X'; znak = '\t'; // \n \r

            //// strings - literały
            //string imieNazwisko = "Jan Kowalski";
            //string pustyNapis = "";
            //pustyNapis = null;

            //const double liczbaPi = 3.14159;
            ////liczbaPi = 2.7172;
            //int a; string adres;

            //Print(imieNazwisko);
            Console.ReadKey();
        }

        static void Print(string txt)
        {
            Console.WriteLine(txt);
        }

        static void StringExamples()
        {
            String imieNazwisko = "Jan Kowalski";
            string lokalizacja1 = "c:\\windows\\system32\\user.dll";
            string lokalizacja2 = @"c:\windows\system32\user.dll";
            string slowo1 = "  Ala ma", slowo2 = "kota   \t";
            string zdanie = slowo1 + " " + slowo2;
            Print(zdanie);
            Print("Długość zdania to: " + zdanie.Length.ToString() + " znaków");
            Print("Wielkie litery: " + zdanie.ToUpper());
            Print("Małe litery: " + zdanie.ToLower());
            Print("Trymowanie: |" + zdanie.Trim()+"|");
            Print("Zamiana z a->* :" + zdanie.Replace("a","*").Replace("A","*") );

            string wzorzec = "ala Ma kOta";
            Print("Czy takie same :" + 
                zdanie.Trim().Equals( wzorzec, StringComparison.OrdinalIgnoreCase ));
            Print("Czy występuje 'ma' : " + zdanie.IndexOf("ma"));
            Print("Substring: " + zdanie.Substring(2, 6));
            zdanie = null;
            Print("Zawartość zmiennej 'zdanie': " + zdanie);
            Print("Sprawdzenia czy pusta lub null: " + String.IsNullOrEmpty(zdanie));


        }
    }
}
