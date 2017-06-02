using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje___użycie
{
    class Program
    {
        static void Main(string[] args)
        {
            // stos
            Stack<int> stos = new Stack<int>();
            stos.Push(12);
            int a = stos.Pop();

            // lista
            List<string> lista = new List<string>();
            lista.Add("element1");
            string b = lista[0];

            // słownik
            Dictionary<string, string> slownik = new Dictionary<string, string>();
            slownik.Add("klucz", "wartosc");
            slownik.Add("inny_klucz", "tekst");
            string c = slownik["klucz"];
        }
    }
}
