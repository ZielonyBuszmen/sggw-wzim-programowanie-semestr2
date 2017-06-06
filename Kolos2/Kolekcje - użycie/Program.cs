using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// trzeba pamiętać o using!
using System.Collections;

namespace Kolekcje___użycie
{
    class Program
    {
        static void Main(string[] args)
        {
            // stos
            Stack<int> stos = new Stack<int>();
            stos.Push(12); // wrzuca element na stos
            int b = stos.Peek(); // zwraca element ze stosu bez jego usuwania
            int a = stos.Pop(); // pobiera element ze stosu

            //kolejka
            Queue<double> kolejka = new Queue<double>();
            kolejka.Enqueue(33); // dodaje element na koniec
            kolejka.Peek(); // zwraca element z początku kolejki bez jego usuwania
            kolejka.Dequeue(); // zdejmuje i zwraca pierwszy element kolejki


            // lista
            List<string> lista = new List<string>();
            lista.Add("element1");
            lista.First(); // zwraca pierwszy element listy
            string d = lista[0]; // zwraca wybrany elemet listy


            // ArrayList - przechowuje wszystko (typ object)
            ArrayList arrList = new ArrayList();
            arrList.Add("asdasd");
            arrList.Add(234);
            object wynik = arrList[0];


            // LinkedList - lista połączona
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(2); // umożwliwia wrzucanie elementów na początek
            linkedList.AddLast(4); // i na koniec
            linkedList.First(); // pobiera pierwszy element
            linkedList.Last(); // pobiera ostatni element




        }
    }
}
