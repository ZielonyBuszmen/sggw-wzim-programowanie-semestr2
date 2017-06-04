# Programowanie obiektowe - kolos nr. 2

## Zagadnienia
#### Wykład 6
* https://www.p-programowanie.pl/c-sharp/metody-wirtualne-abstrakcyjne-i-polimorfizm/
	* Metody wirtualne (virtual w bazowej i override w pochodnej);
	* Polimorfizm (przypisanie obiektu klasy pochodnej do typu klasy bazowej)
	* Metody abstrakcyjne 
* Interfejsy: https://4programmers.net/C_sharp/Interfejsy

#### Wykład 8
* Typy ogólne (generyczne) -> Klasy ogólnie i metody ogólne: https://4programmers.net/C_sharp/Typy_generyczne
* Kolekcje (System.Collections, System.Collections.Generic) (Słownik, Stos, Lista): //4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_7#kolekcje

#### Wykład 9
* Zastosowanie interfejsów
    * IEnumerable, IEnumerator: http://cezarywalenciuk.pl/blog/programing/post/ienumerable-i-ienumerator-implementowanie-tych-interfejsow
    * ICollection
    * IConvertible

#### Wykład 10
* Przeciążanie operatorów: http://cezarywalenciuk.pl/blog/programing/post/kurs-obiektowosc-w-c-przeciazanie-operatorow-16

#### Wykład 11
* Delegaty i zdarzenia, metody anonimowe: https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_6
* Funkcje Lambda: https://4programmers.net/C_sharp/Wyra%C5%BCenie_Lambda

#### Wykład 12
* Serializacja + znalezione w zakładkach

## Spis treści
* *[Przydatne skróty](#przydatne-skróty)*
* *[Przydatne snippety](#przydatne-snippety)*
* **[Przykładowy kod](#przykładowy-kod)**
    * wykład 6
        * [Interfejsy](#6-interfejs)
    * wykład 8
        * [Typy ogólne (generyczne)](#8-generyczne)
        * [Kolekcje](#8-kolekcje)
    * wykład 9
      * [Implementacja wbudowanych interfejsów](#9-implementacja-interfejsow)
           * [IEnumerable](#9-ienumerable)
           * [IEnumerable\<T\>](#9-ienumerable-t)
           * [IComparable\<T\>](#9-icomparable-t)
           * [IConvertible](#9-iconvertible)
      * [Iteratory](#9-iteratory)
    * wykład 10
        * [Przeciążanie operatorów](#10-przeciazanie-operatorow)
    * wykład 11
        * [Delegaty](#11-delegaty)
        * [Zdarzenia](#11-zdarzenia)
        * [Funckje Lambda](#11-lambda)
    * wykład 12
        * [Serializacja](#12-serializacja)


## Przydatne skróty
* `Ctrl + K + D` (trzymając Ctrl wciskamy najpierw K potem D) - formatowanie kodu

* `Ctrl + Shift + Space` - wyświetla parametry funkcji i jej opis

![photo](https://raw.githubusercontent.com/ZielonyBuszmen/sggw-wzim-programowanie/master/jpg/ctrl_shift_space.jpg)


* Implementacja interfejsu - wystarczy przytrzymać myszkę nad nazwą, nacisnąć na żarówkę i wybrać "implement interface" (tak jak na screenie):

![photo](https://raw.githubusercontent.com/ZielonyBuszmen/sggw-wzim-programowanie/master/jpg/implementowanie-interfejsu.jpg)

## Przydatne snippety

* `ctor` - *użyty wewnątrz klasy tworzy konstruktor*
```csharp
public PrzykladowaKlasa()
{
}
```

* `prop` - *tworzy właściwość w klasie*
```csharp
public int MyProperty { get; set; }
```


* `propfull` - *tworzy 'pełną' właściwość w klasie*
```csharp
private int myVar;

public int MyProperty
{
    get { return myVar; }
    set { myVar = value; }
}
```

* `indexer` - *tworzy 'indeksator'*
```csharp
public object this[int index]
{
    get { /* return the specified index here */ }
    set { /* set the specified index to value here */ }
}
```


# Przykładowy kod

## <a id="6-interfejs"></a> Interfejs (wykład 6) 
https://4programmers.net/C_sharp/Interfejsy
```csharp
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
```

## <a id="8-generyczne"></a> Typy ogólne (generyczne) (wykład 8)
https://4programmers.net/C_sharp/Typy_generyczne

```csharp
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
``` 

## <a id="8-kolekcje"></a> Kolekcje (System.Collections, System.Collections.Generic) (wykład 8)
* Stos
* Lista
* Słownik

https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_7#kolekcje

Użycie przykładowych kolekcji
```csharp
// gdyby edytor nie dodał usingów
using System.Collections;
using System.Collections.Generic;

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
```



## <a id="9-iteratory"></a> Iteratory (wykład 9)

### <a id="9-ienumerable"></a> interfejs IEnumerator i IEnumerable(wykład 9)

http://cezarywalenciuk.pl/blog/programing/post/ienumerable-i-ienumerator-implementowanie-tych-interfejsow

```csharp
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
            Pracownicy robole= new Pracownicy();
            foreach (var robol in robole)
            {
                Console.WriteLine(robol);
            }

            Console.ReadKey();
        }
    }
}
```

### <a id="9-ienumerable-t"></a>  interfejs IEnumerable\<T\> (wykład 9)
```csharp
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
```

## <a id="9-implementacja-interfejsow"></a> Implementacja wbudowanych interfejsów (wykład 9)

### <a id="9-icomparable-t"></a> interfejs IComparable\<T\> (wykład 9)

### <a id="9-iconvertible"></a> interfejs IConvertible (wykład 9)
zadanie od karwosza
Dla klasy Book zaimplementuj sensownie interfejs IConvertible
<pre>
    struct Book : IConvertible
    {
        string m_Title;

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public override string ToString()
        {
            return this.Title.ToString();
        }
    }
</pre>



## <a id="10-przeciazanie-operatorow"></a>  Przeciążanie operatorów (wykład 10)
http://cezarywalenciuk.pl/blog/programing/post/kurs-obiektowosc-w-c-przeciazanie-operatorow-16


```csharp
class Ble
{
    // przeciążenie operatora +
    public static Ble operator+(Ble a, Ble b)
    {
        return new Ble(a+b);
    }
}
```
## <a id="11-delegaty"></a>  Delegaty (wykład 11)
https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_6


## <a id="11-zdarzenia"></a> Zdarzenia (wykład 11)
https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_6

## <a id="11-lambda"></a> Funckje Lambda (wykład 11)
https://4programmers.net/C_sharp/Wyra%C5%BCenie_Lambda


## <a id="12-serializacja"></a>  Serializacja (wykład 12)

