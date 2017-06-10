# Programowanie obiektowe - kolos nr. 2

## Zagadnienia
#### Wykład 6
* Przypomnienie o metodach wirtualnych, polimorfizmie i metodach abstrakcyjnych https://www.p-programowanie.pl/c-sharp/metody-wirtualne-abstrakcyjne-i-polimorfizm/
* Interfejsy: https://4programmers.net/C_sharp/Interfejsy

#### Wykład 8
* Typy ogólne (generyczne) -> Klasy ogólnie i metody ogólne: https://4programmers.net/C_sharp/Typy_generyczne
* Kolekcje (Stos, Kolejka, Lista, ArrayList, LinkedList): 
    * http://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_7#kolekcje
    * http://www.altcontroldelete.pl/artykuly/operacje-na-kolekcjach-w-c-/

#### Wykład 9
* Zastosowanie interfejsów
    * IEnumerable, IEnumerator: http://cezarywalenciuk.pl/blog/programing/post/ienumerable-i-ienumerator-implementowanie-tych-interfejsow
    * ICollection
    * IComparable, IComparer

#### Wykład 10
* Przeciążanie operatorów: http://cezarywalenciuk.pl/blog/programing/post/kurs-obiektowosc-w-c-przeciazanie-operatorow-16

#### Wykład 11
* Delegaty
    * https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_6
* Funkcje Lambda z Func i Action: 
    * https://4programmers.net/C_sharp/Wyra%C5%BCenie_Lambda
    * http://cezarywalenciuk.pl/blog/programing/post/c-delegaty-action-i-func

#### Wykład 12
* Serializacja binarna
* Serializacja XML: https://www.codeproject.com/Articles/483055/XML-Serialization-and-Deserialization-Part

#### Wykład 13
* Refleksja
* CodeDOM

## Spis treści
* *[Przydatne skróty](#przydatne-skróty)*
* *[Przydatne snippety](#przydatne-snippety)*
* **[Przykładowy kod](#przykładowy-kod)**
    * wykład 6
        * [Interfejsy](#6-interfejs)
    * wykład 8
        * [Typy ogólne (generyczne)](#8-generyczne)
        * [ Kolekcje (Stos, Kolejka, Lista, ArrayList, LinkedList)](#8-kolekcje)
    * wykład 9
        * [Iteratory](#9-iteratory)
            * [IEnumerable](#9-ienumerable)
            * [IEnumerable\<T\>](#9-ienumerable-t)
      * [Implementacja wbudowanych interfejsów](#9-implementacja-interfejsow)
           * [IComparable\<T\>](#9-icomparable-t)
           * [ICollection](#9-icollection-t)
    * wykład 10
        * [Przeciążanie operatorów](#10-przeciazanie-operatorow)
    * wykład 11
        * [Delegaty](#11-delegaty)
        * [Event Args](#11-event-args)
        * [Funckje Lambda z Func i Action](#11-lambda)
    * wykład 12
        * [Serializacja binarna](#12-serializacja-bianarna)
        * [Serializacja XML](#12-serializacja-xml)
    * Wykład 13
        * [CodeDOM](#13-code-dom)
        * [Refleksja](#13-refleksja)



## Przydatne skróty
* `Ctrl + K, Ctrl + D` - formatowanie kodu

* `Ctrl + Shift + Space` - wyświetla parametry funkcji i jej opis

![photo](https://raw.githubusercontent.com/ZielonyBuszmen/sggw-wzim-programowanie/master/jpg/ctrl_shift_space.jpg)


* Implementacja interfejsu - wystarczy przytrzymać myszkę nad nazwą, nacisnąć na żarówkę i wybrać "implement interface" (tak jak na screenie):

![photo](https://raw.githubusercontent.com/ZielonyBuszmen/sggw-wzim-programowanie/master/jpg/implementowanie-interfejsu.jpg)

* Open in Explorer - *Prawym myszy* na projekt -> *Open folder in file Explorer*
![photo](https://raw.githubusercontent.com/ZielonyBuszmen/sggw-wzim-programowanie/master/jpg/show-in-explorer.jpg)

* Pliki z serializacji zapisują się w ***\bin\Debug***

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
* Stos (Stack)
* Kolejka (Queue)
* Lista (List)
* ArrayList
* LinkedList


https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_7#kolekcje
http://www.altcontroldelete.pl/artykuly/operacje-na-kolekcjach-w-c-/

Użycie przykładowych kolekcji
```csharp
// gdyby edytor nie dodał usingów
using System.Collections;
using System.Collections.Generic;

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
```csharp
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
```

### <a id="9-icollection-t"></a> interfejs ICollection (wykład 9)

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
## <a id="11-delegaty"></a> Delegaty (wykład 11)
https://4programmers.net/C_sharp/Wprowadzenie/Rozdzia%C5%82_6
http://cezarywalenciuk.pl/blog/programing/post/c-delegaty-action-i-func
```csharp
// delegat na funkcję zwracającą int i przyjmującą int
delegate int PierwszyDelegat(int a);

// delegat przyjmujący funkcję przyjmującą string
delegate void DrugiDelegat(string zmienna);

// ogólny delegat przyjmujący typ T i zwracający typ T
delegate T OgólnyDelegat<T>(T cos);

// przykładowa klasa z funkcjami
class Test<T>
{
    // zmienna "delegat", nie jest nigdzie użwywany
    PierwszyDelegat delegatWKlasie;
    // odwołanie się do tego delegata
    // delegatWKlasie = funkcja;

    public static void Wyswietl(string wartosc)
    {
        Console.WriteLine(wartosc);
    }
}

class Program
{
    // przykładowe funkcje
    public static int Kwadrat(int a)
    {
        return a * a;
    }
    public static int Ble(int c)
    {
        return c - 120;
    }

    static void Main(string[] args)
    {
        Test<int> tst = new Test<int>();
        // przypisywanie delegatom funkcji
        PierwszyDelegat delegat1;
        delegat1 = Kwadrat;
        delegat1 += Ble; // dodanie drugiej funkcji do delegata
        delegat1(5); // wywołanie delegatu

        // przypisanie funkcji statycznej z klasy ogólnej
        DrugiDelegat delegat2 = Test<int>.Wyswietl;

        //przypisanie funkcji do delegata ogólnego
        OgólnyDelegat<int> ogólny = Ble;
        // wywołanie ogólnego delegata
        ogólny(2);
    }
}
```


## <a id="11-event-arg"></a> Event Args (wykład 11)

```csharp
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
```

## <a id="11-lambda"></a> Funckje Lambda (wykład 11)
https://4programmers.net/C_sharp/Wyra%C5%BCenie_Lambda

```csharp
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
```


## <a id="12-serializacja-bianarna"></a> Serializacja binarna (wykład 12)</a>

* Pliki z serializacji zapisują się w ***\bin\Debug***

```csharp
// ważne usingi
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// przykładowa klasa do serializacji
[Serializable]
class Osoba
{
    string imie;

    public Osoba(string imie)
    {
        this.imie = imie;
    }

    public override string ToString()
    {
        return imie;
    }
}

// określenie tego, co ma się serializować
[Serializable]
public class RozszerzonaOsoba : ISerializable
{
    int pesel;
    string nazwisko;
    string imie;
    [NonSerialized] // nie musimy bawić się w definicję ISerializable, itd. Równoważnie można dodać [NonSerialized]
    double dochód;

    // określany pola, które mają się serializować
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Pesel", pesel);
        info.AddValue("Nazwisko", nazwisko);
        info.AddValue("Imię", imie);
    }
    // konstruktor "odserializujący"
    protected RozszerzonaOsoba(SerializationInfo info, StreamingContext context)
    {
        pesel = info.GetInt32("Info");
        nazwisko = info.GetString("Info");
        imie = info.GetString("Info");
    }

}

class Program
{
    // zapis obiektu do pliku
    static void Zapisz(Osoba o, string plik)
    {
        FileStream fs = new FileStream(plik, FileMode.Create);
        BinaryFormatter bw = new BinaryFormatter();
        bw.Serialize(fs, o);
        fs.Close();
    }

    // odczyt obiektu z pliku
    static Osoba Odczytaj(string plik)
    {
        FileStream fs = new FileStream(plik, FileMode.Open);
        BinaryFormatter bf = new BinaryFormatter();
        return (Osoba)bf.Deserialize(fs);

    }

    static void Main(string[] args)
    {
        // przykładowe użycie
        Osoba os1 = new Osoba("Omega");
        Zapisz(os1, "omega.dat");
        Osoba odczytana = Odczytaj("omega.dat");
        Console.WriteLine(odczytana);

        Console.ReadKey();
    }
}

```

## <a id="12-serializacja-xml"></a> Serializacja XML (wykład 12)</a> 
https://www.codeproject.com/Articles/483055/XML-Serialization-and-Deserialization-Part

* Pliki z serializacji zapisują się w ***\bin\Debug***

1. Serializacja XML działa tylko na publicznych polach i właściwościach
2. Serializacja XML nie zapisuje typu zmiennej
3. Potrzebujemy domyślnego konstruktora (bez parametrów) w klasie którą chcemy serializować

```csharp
// ważne usingi
using System.IO;
using System.Xml.Serialization;

namespace SerializacjaXML
{
    // przykładowa klasa do serializacji
    [Serializable]
    public class Osoba
    {
        // serializacji do XML podlegają tylko pola publiczne
        public string imie;

        public Osoba(string imie)
        {
            this.imie = imie;
        }

        public Osoba()
        {
            imie = "NIC";
        }

        public override string ToString()
        {
            return imie;
        }
    }

    class Program
    {
        // zapis obiektu do pliku XML
        static void Zapisz(Osoba o, string plik)
        {
            FileStream fs = new FileStream(plik, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Osoba));
            serializer.Serialize(fs, o);
            fs.Close();
        }

        // odczyt obiektu z pliku xml
        static Osoba Odczytaj(string plik)
        {
            FileStream fs = new FileStream(plik, FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(Osoba));
            return (Osoba)serializer.Deserialize(fs);

        }

        static void Main(string[] args)
        {
            // przykładowe użycie
            Osoba os1 = new Osoba("Omega");
            Zapisz(os1, "omega.xml");
            Osoba odczytana = Odczytaj("omega.xml");
            Console.WriteLine(odczytana);

            Console.ReadKey();
        }
    }
```
## <a id="13-refleksja"></a> Refleksja (wykład 13)</a> 

## <a id="13-code-dom"></a> CodeDOM (wykład 13)</a> 



