using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejs_IEnumerable_T
{
    class ListaCzynności<T> : IEnumerable<T>
    {
        T[] przechowalnik;
        int licznik = 0;
        public ListaCzynności(int ilosc)
        {
            przechowalnik = new T[ilosc];
        }


        public void Dodaj(T rzecz)
        {
            this.przechowalnik[licznik] = rzecz;
            licznik++;
        }

        // ---------------------------------------------
        // metody z IEnumerable<T>

        public IEnumerator<T> GetEnumerator()
        {
            // szybszy sposób implementacji enumeratora
            for (int i = 0; i < przechowalnik.Length; i++)
            {
                // ważne słówko YIELD
                yield return przechowalnik[i];
            }

        }

        // to też być musi
        IEnumerator IEnumerable.GetEnumerator()
        {
            // zwracamy funkcję napisaną kilka linije wyżej
            return this.GetEnumerator();
        }
        // ---------------------------------------------

        // własny enumerator
        public IEnumerable OdTyłu()
        {
            for (int i = przechowalnik.Length - 1; i >= 0; i--)
            {
                yield return przechowalnik[i];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // przypadki użycia
            ListaCzynności<string> listaToDo = new ListaCzynności<string>(5);
            listaToDo.Dodaj("Zapytać się o zadanie z analizy");
            listaToDo.Dodaj("Ble");
            listaToDo.Dodaj("Wydrukować ściągi na kartce w kratkę");
            listaToDo.Dodaj("Naucyzć się na 2 kolosy z elektro");
            listaToDo.Dodaj("Kupić mleko");

            // korzystamy z funkcji GetEnumerator()
            foreach (var item in listaToDo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // korzystamy z funkcji OdTyłu()
            foreach (var item in listaToDo.OdTyłu())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
