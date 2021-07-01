using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetlaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznik = 10;
            while (licznik>0)
            {
                // blok petli while
                Console.WriteLine("licznik=" + licznik);
                licznik--;
            }

            // do while
            licznik = -10;
            do
            {
                Console.WriteLine("licznik=" + licznik);
                licznik--;
            } while (licznik > 0);

            // petla nieskonczona
            while (true)
            {
                Console.Write("podaj liczbe >100 i podzielna przez 2: ");
                int liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba>100 && liczba%2==0)
                {
                    Console.WriteLine("liczba jest ok");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
