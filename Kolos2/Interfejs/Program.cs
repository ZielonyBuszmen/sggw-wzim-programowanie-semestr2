using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejs
{
    // przykładowy interfejs, może (ale nie musi) zaczynać się litery I
    interface IMojInterfejs
    {
        void Drukowanie(int a);
    }

    // kolejny interfejs
    interface DrugiInterfejs
    {
        int Malowanie(string a, double b);
    }

    // klasa może `implementować` kilka `interfejsów`. Wystarczy wypisać je po przecinku 
    class Klasa : IMojInterfejs, DrugiInterfejs
    {
        // `implementacja` metody `zadeklarowanej` w interfejsie IMojInterfejs
        public void Drukowanie(int a)
        {
            Console.WriteLine(a);
        }

        // implementacja metody z interfejsu `DrugiInterfejs`
        public int Malowanie(string a, double b)
        {
            Console.WriteLine("{0} -> {1}", a, b);
            return 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // dostępna jest tylko funkcja `Drukowanie`
            IMojInterfejs pierwszy = new Klasa();
            pierwszy.Drukowanie(12);

            // dostępna jest tylko funkcja `Malowanie`
            DrugiInterfejs drugi = new Klasa();
            drugi.Malowanie("s", 2);

            // dostępne są obie funkcje
            Klasa trzeci = new Klasa();
            trzeci.Drukowanie(234);
            trzeci.Malowanie("b", 77);

        }
    }
}
