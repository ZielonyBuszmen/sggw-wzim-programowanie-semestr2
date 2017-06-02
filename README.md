# Programowanie obiektowe - kolos nr. 2


#### Wykład 6:
* https://www.p-programowanie.pl/c-sharp/metody-wirtualne-abstrakcyjne-i-polimorfizm/
	* Metody wirtualne (virtual w bazowej i override w pochodnej);
	* Polimorfizm (przypisanie obiektu klasy pochodnej do typu klasy bazowej)
	* Metody abstrakcyjne (gdy taka jest w klasie, to klasa jest abstrakcyjna również) 
* Interfejsy: https://4programmers.net/C_sharp/Interfejsy


#### Wykład 8
* Typy ogólne (generyczne) -> Klasy ogólnie i metody ogólne: https://4programmers.net/C_sharp/Typy_generyczne
* Kolekcje (System.Collections, System.Collections.Generic) (Kolejka, stos, Lista): //4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_7#kolekcje

#### Wykład 9 - zastosowanie interfejsów
* IEnumerable, IEnumerator + znalezione w zakładkach
* ICollection – chyba wywalic
* IConvertible – chyba wywalic

#### Wykład 10
* Przeciążanie operatorów: http://cezarywalenciuk.pl/blog/programing/post/kurs-obiektowosc-w-c-przeciazanie-operatorow-16


#### Wykład 11
* Delegaty i zdarzenia, metody anonimowe: https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_6
* Funkcje Lambda: https://4programmers.net/C_sharp/Wyra%C5%BCenie_Lambda

#### Wykład 12
* Serializacja + znalezione w zakładkach


## Przydatne skróty
* `Ctrl + Shift + Space` - wyświetla parametry funkcji i jej opis
* `Ctrl + K + D` (trzymając Ctrl wciskamy najpierw K potem D) - formatowanie kodu


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

* `propfull` - *tworzy 'pewłną' właściwość w klasie*
```csharp
	private int myVar;

	public int MyProperty
	{
		get { return myVar; }
		set { myVar = value; }
	}
```

* `propfull` - *tworzy 'pewłną' właściwość w klasie*
```csharp
	private int myVar;

	public int MyProperty
	{
		get { return myVar; }
		set { myVar = value; }
	}
```

* `indexer` - *tworzy 'indeksator'
```csharp
	public object this[int index]
	{
		get { /* return the specified index here */ }
		set { /* set the specified index to value here */ }
	}
```


# Przykładowy kod

## Interfejs (wykład 6)
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

## Typy ogólne (generyczne) (wykład 8)
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

## Kolekcje (System.Collections, System.Collections.Generic) (wykład 8)
* Kolejka
* Stos
* ArrayList
* Lista

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


## Implementacja wbudowanych interfejsów (wykład 9)


### interfejs IEnumerable (wykład 9)


### interfejs IEnumerable\<T\> (wykład 9)


### interfejs IComparable\<T\> (wykład 9)

### interfejs IConvertible (wykład 9)
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

### Iteratory (wykład 9)


## Przeciążanie operatorów (wykład 10)
http://cezarywalenciuk.pl/blog/programing/post/kurs-obiektowosc-w-c-przeciazanie-operatorow-16

## Delegaty (wykład 11)
https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_6


## Zdarzenia (wykład 11)
https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_6

## Funckje Lambda (wykład 11)
https://4programmers.net/C_sharp/Wyra%C5%BCenie_Lambda


## Serializacja (wykład 12)