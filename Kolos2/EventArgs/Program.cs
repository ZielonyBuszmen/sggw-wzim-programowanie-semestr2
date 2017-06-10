using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventArgs
{
    // tworzymy klasę, która będzie przechowywać informacje dla zdarzenia
    // musi dziedziczyć z System.EventArgs
    class NowaCenaEventArgs : System.EventArgs
    {
        public readonly int NowaCena; // tutaj przechowujemy nową cenę produktu, pole tylko do odczytu
        public NowaCenaEventArgs(int nowaCena) // w konstruktorze ustawiamy nową cenę
        {
            NowaCena = nowaCena;
        }
    }

    // właściwa klasa z produktem
    class Produkt
    {
        // Tworzymy pole EVENT
        // type to EventHandler<NowaCenaEventArgs>
        // NowaCenaEventArgs to typ naszej klasy przechowującej odatkowe dane dla zdarzenia
        // a samo EventHandler<> to typ wbudowany w język
        // jak widać, nie musimy tworzyć wcześniej żadnego delegata
        public event EventHandler<NowaCenaEventArgs> NaszEvent;

        public readonly string nazwa; // nazwa produktu
        int cena; // jego cena

        // właściwość Cena
        public int Cena
        {
            get { return cena; } // get jest normalny, nie ma co pisać
            set // natomiast set jest troszeczkę inny
            {
                cena = value; // standardzik - ustawiamy cenę
                // i niżej zaczyna się już lekka magia
                // odwołujemy się do funkcji 'zmienionoCene' (jest ona 10 linijek niżej).
                // Przekazjemy do niej obiekt typu NocaCenaEventArgs
                // tak, to ten obiekt, który ma przechowywać dodatkowe informacje dla zdarzenia
                // w tym przypadku przechowuje nową cenę
                zmienionoCene(new NowaCenaEventArgs(value));
            }
        }

        // klasyczny konstruktor, ustawia tylko pola
        public Produkt(string nazwa, int cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }

        // wspomniana wcześniej funkcja zmienionoCenę 
        protected void zmienionoCene(NowaCenaEventArgs e)
        {
            // odwołujemy się do eventu przekazując mu TEN obiekt, oraz obiekt klasy z Nową ceną
            NaszEvent.Invoke(this, e);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // zobaczmy przykładowe użycie
            // tworzymy przykladowe produkty
            Produkt cukierPuder = new Produkt("cukier puder", 5);
            Produkt kakao = new Produkt("kakao", 7);

            // do eventu w cukierPuder dodajemy "subskrybenta", czyli funkcję, która jest zaimplementowana kilka linijek niżej
            cukierPuder.NaszEvent += CzyzbyZmienionoCene;

            // no i zmieniamy cenę, by wywołać event
            cukierPuder.Cena = 23;

            Console.ReadKey();
        }

        // funkcja - subskrybent, którą możemy dodać do naszego eventu
        // musi pobierać dwa parametry
        // pierwszy z nich to Object
        // drugi z nich to klasa przechowująca dodatkowe informacje
        // Obiekt - to obiekt który wywołał to zdarzenie (event)
        public static void CzyzbyZmienionoCene(Object o, NowaCenaEventArgs e)
        {
            Produkt produkt = (Produkt)o; // wyświetlamy sobie informacje
            Console.WriteLine("O! Zminiono cenę prouktu o nazwie: {0}", produkt.nazwa);
            Console.WriteLine("Nowa cena wynosi całe {0} zł", e.NowaCena);
        }
    }
}
