using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable
{
    class Osoba : IComparable<Osoba>
    {
        int wiek;
        string imie;
        // zwraca wartość dodatnią, jeśli element z tej klasy jest większy
        // wartość ujemną - gdy element z tej klasy jest mniejszy
        // 0 - gdy są równe
        public int CompareTo(Osoba inna)
        {
            if (this.wiek > inna.wiek) return 1;
            if (this.wiek < inna.wiek) return - 1;
            // jeśli wiek taki sam porownujemy imie
            if (this.wiek==inna.wiek) {
                return this.imie.CompareTo(inna.imie);
            }
            return 0;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
