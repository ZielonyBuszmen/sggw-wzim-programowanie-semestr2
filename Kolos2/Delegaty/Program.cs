using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    // delegat na funkcję zwracającą int i przyjmującą int
    delegate int PierwszyDelegat(int a);

    // delegat przyjmujący funkcję przyjmującą string
    delegate void DrugiDelegat(string zmienna);

    // ogólny delegat przyjmujący typ T i zwracający typ T
    delegate T OgólnyDelegat<T>(T cos);

    // przykładowa klasa z funkcjami
    class Test<T>
    {
        // zmienna "delegat", nie jest nigdzie użwywany
        PierwszyDelegat delegatWKlasie;
        // odwołanie się do tego delegata
        // delegatWKlasie = funkcja;

        public static void Wyswietl(string wartosc)
        {
            Console.WriteLine(wartosc);
        }
    }

    class Program
    {
        // przykładowe funkcje
        public static int Kwadrat(int a)
        {
            return a * a;
        }
        public static int Ble(int c)
        {
            return c - 120;
        }

        static void Main(string[] args)
        {
            Test<int> tst = new Test<int>();
            // przypisywanie delegatom funkcji
            PierwszyDelegat delegat1;
            delegat1 = Kwadrat;
            delegat1 += Ble; // dodanie drugiej funkcji do delegata
            delegat1(5); // wywołanie delegatu

            // przypisanie funkcji statycznej z klasy ogólnej
            DrugiDelegat delegat2 = Test<int>.Wyswietl;

            //przypisanie funkcji do delegata ogólnego
            OgólnyDelegat<int> ogólny = Ble;
            // wywołanie ogólnego delegata
            ogólny(2);
        }
    }
}
