using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy_ogólne__generyczne_
{
    // klasa generyczna
    class Ogolna<T>
    {
        private T wartosc;
        public T ZwrocWartosc()
        {
            return wartosc;
        }
    }

    class Program
    {
        // funkcja generyczna
        public static void FunkcjaOgolna<G>(G a, int b)
        {
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            // tworzenie obiektu klasy generycznej
            Ogolna<int> obiekt = new Ogolna<int>();

            // odwoływanie się do metody generycznej
            FunkcjaOgolna<string>("tekst", 123);
        }
    }
}
