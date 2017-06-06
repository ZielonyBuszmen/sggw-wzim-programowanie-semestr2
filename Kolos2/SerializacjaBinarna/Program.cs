using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ważne usingi
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializacjaBinarna
{
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
}
