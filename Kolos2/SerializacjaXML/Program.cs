using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
