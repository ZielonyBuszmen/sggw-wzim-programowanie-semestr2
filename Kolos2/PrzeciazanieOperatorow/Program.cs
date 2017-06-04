using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzeciazanieOperatorow
{
    class Operatory
    {
        int wartosc;
        public Operatory(int wartosc)
        {
            this.wartosc = wartosc;
        }
        public static Operatory operator +(Operatory a, Operatory b)
        {
            return new Operatory(a.wartosc - b.wartosc * 7);
        }

        public void wyswietl()
        {
            Console.WriteLine(wartosc);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operatory liczba1 = new Operatory(12);
            Operatory liczba2 = new Operatory(44);
            Operatory liczba3 = liczba1 + liczba2;
            liczba3.wyswietl();

            Console.ReadKey();
        }
    }
}
