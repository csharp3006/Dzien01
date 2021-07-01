using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjaWarunkowa
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchCase();

            int wiek = 31;
            bool czyObywatelPolski = false;
            bool czyKarany = true; // true, jesli skazany
                                   // false, jesli nie skazany

            if (czyObywatelPolski)
            {
                // dalsze sprawdzenie co do praw wyborczych
                // 35 - prezydent
                // 30 - senator
                // 21 - posel
                // 18 - zeby głosować
                if (wiek >= 35 && !czyKarany)
                {
                    Console.WriteLine("możesz na prezydenta");
                }
                else if (wiek >= 30 && !czyKarany)
                {
                    Console.WriteLine("możesz na senatora");
                }
                else if (wiek >= 21 && !czyKarany)
                {
                    Console.WriteLine("możesz na posła");
                }
                else if (wiek >= 18)
                {
                    Console.WriteLine("możesz głosować");
                }
                else
                {
                    Console.WriteLine("za młody jesteś");
                }

            }
            else
            {
                Console.WriteLine("Nie masz obywatelstwa");
            }
        }
    
        static void SwitchCase()
        {
            Console.Write("Podaj ocene od 1 do 4: ");
            int ocena = Convert.ToInt32(Console.ReadLine());
            switch (ocena)
            {
                case 1:
                    Console.WriteLine("niedostateczna");
                    break;
                case 2:
                    Console.WriteLine("mierna");
                    break;
                case 3:
                    Console.WriteLine("dostateczna");
                    break;
                case 4:
                    Console.WriteLine("dobra");
                    break;

                default:
                    Console.WriteLine("nie znam takiej oceny");
                    break;

            }
        }
    }
}
