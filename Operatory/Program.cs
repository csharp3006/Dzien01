using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatory
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacyjneRelacyjne();
            OperatoryPrzypisania();
            OperatioryArytmetyczne();
            Console.ReadKey();
        }

        static void OperatoryPrzypisania()
        {
            Int64 a = 4352325345354, b = -2342342424, c = 124324324234;
            c = a; // przypisanie wartości
            c += a; //c = c + a;
            c -= a; // c= c-a
            c *= a; // c = c * a
            c /= a; // c = c / a
            c %= a; // c = c % a
        }

        static void OperatioryArytmetyczne()
        {
            double x = -10.345, y = 543.21;
            double z;
            z = x + y;
            z = x - y;
            z = x * y;
            z = x / y;
            z = x % y; // dzielenie z resztą

            int a = 10;
            a++; // a = a +1
            a--; // a = a -1

            Console.WriteLine((++a).ToString());

            a++; // operator ink. przyrostkowy
            ++a; // operator ink. przedrostkowy
        }

        static void OperacyjneRelacyjne()
        {
            double x = -1234.56, y = 123456789.12;
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x > y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x < y);
            Console.WriteLine(x <= y);

            // ternary operator
            Console.WriteLine(x == y ? "OK" : "ERROR");
            string s = (x == y ? "OK" : "ERROR");

        }

        static void OperatoryLogiczne()
        {
            bool a = false, b = true;
            bool c;
            c = a && b; // iloczyn logiczny - AND
            c = a || b; // suma logiczna - OR
            c = !a; // negacja - NOT
            c = !(!a); // podwojny NOT
        }
    }
}
