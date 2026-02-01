using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalicz2
{
    public class Pacjent
    {
        // Atrybuty klasy
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public List<string> HistoriaChorob { get; set; }

        
        public Pacjent() // Konstruktor domyślny - z pustymi danymi
        {
            Imie = "";
            Nazwisko = "";
            Pesel = "";
            HistoriaChorob = new List<string>();
        }

        public Pacjent(string imie, string nazwisko, string pesel) // Konstruktor przyjmujący dane jako argumenty
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            HistoriaChorob = new List<string>();
        }
        public void DodajChorobe(string choroba) // Metoda dodająca chorobę do listy
        {
            HistoriaChorob.Add(choroba);
        }

        
        public void Wyswietl() // Metoda wyświetlająca dane pacjenta wraz z historią
        {
            Console.WriteLine($"Pacjent: {Imie} {Nazwisko}, PESEL: {Pesel}");
            Console.Write("Historia chorób: ");
            if (HistoriaChorob.Count > 0)
            {
                string tekst = string.Join(", ", HistoriaChorob);
                Console.WriteLine(tekst);
            }
            else
            {
                Console.WriteLine("Brak wpisów");
            }
            Console.WriteLine("---------------------------");
        }
    }
}
