using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // składnia
            // (parametry) => {zwracana wartość
            // Func<Parametr1, Parametr2, CoZwraca> zmienna = (parametry) => {zwracana wartość}

            // kwadrat przyjmuje jeden parametr int i zwraca int
            Func<int, int> kwadrat = (int ba) => { return ba * ba; };
            // jest równoważne
            // int kwadrat(int a) { return a*a };
            kwadrat(5); // wywołanie funckji

            // przyjmuje dwa double, zwraca int
            Func<double, double, int> funkcja2 = (double p1, double p2) => { return 1; };
            funkcja2(12.5, 33.3);

            // nic nie przyjmuje, zwraca string
            Func<string> funkcja3 = () => { return "sss"; };
            funkcja3();

            // ---------------------------
            // Action
            // Action coś przyjmuje, ale nic nie zwraca
            Action<int> funkcja4 = (int a) => { };


        }
    }
}
