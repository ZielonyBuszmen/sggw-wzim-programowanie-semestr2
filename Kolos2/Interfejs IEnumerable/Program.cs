using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WAŻNE - aby implementować ten interfejs, trzeba ręcznie dodać System.Collections
using System.Collections;

namespace Interfejs_IEnumerable
{
    // przykładowa klasa, która zawiera w sobie listę pracowników
    // implementujemy oba interfejsy -> IEnumerator i IEnumerable
    class Pracownicy : IEnumerator, IEnumerable
    {
        string[] lista_pracownikow;
        int licznik = -1;

        public Pracownicy()
        {
            lista_pracownikow = new string[]
            { "Programista", "Sprzątaczka", "Pan Wiesiu", "Halina z dziekanatu", "Prezes Wojtek Ch." };
        }

        //-----------------------------------------------------------
        // właściwość z IEnumerator
        // zwraca 'aktualny' element (pracownika)
        public object Current
        {
            get { return this.lista_pracownikow[licznik]; }
        }

        // metoda z IEnumerator
        // przechodzi do następnego elementu (pracownika)
        public bool MoveNext()
        {
            // zwiększamy licznik. Jeśli nie wykracza poza tablicę, zwracamy true, 
            // w przeciwnym wypadku false
            licznik++;
            if (licznik < this.lista_pracownikow.Length) return true;
            else return false;
        }

        // metoda z IEnumerator
        public void Reset()
        {
            // zmieniamy licznik do domyślnej wartości
            licznik = -1;
        }

        //-----------------------------------------------------------
        // metoda z IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pracownicy robole = new Pracownicy();
            foreach (var robol in robole)
            {
                Console.WriteLine(robol);
            }

            Console.ReadKey();
        }
    }
}
