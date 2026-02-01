using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalicz2
{
    public class Dziennik
    {
        
        private List<Pacjent> listaPacjentow;// Atrybut - lista pacjentów

        public Dziennik()
        {
            listaPacjentow = new List<Pacjent>();
        }

       
        public void DodajPacjenta(Pacjent p) // Metoda dodająca nowego pacjenta
        {
            listaPacjentow.Add(p);
            Console.WriteLine($"Dodano pacjenta: {p.Imie} {p.Nazwisko}");
        }
        public void UsunPacjenta(string pesel)
        {
            var pacjent = listaPacjentow.Find(p => p.Pesel == pesel);
            if (pacjent != null)
            {
                listaPacjentow.Remove(pacjent);
                Console.WriteLine($"Usunięto pacjenta o PESEL: {pesel}");
            }
            else
            {
                Console.WriteLine("Nie znaleziono pacjenta o podanym numerze PESEL.");
            }
        }

        // Metoda wyświetlająca wszystkich pacjentów
        public void WyswietlWszystkichPacjentow()
        {
            Console.WriteLine("\n--- LISTA WSZYSTKICH PACJENTÓW ---");
            foreach (var p in listaPacjentow)
            {
                p.Wyswietl();
            }
        }

        // Metoda wyszukująca pacjenta po PESEL
        public void ZnajdzPacjenta(string pesel)
        {
            var pacjent = listaPacjentow.Find(p => p.Pesel == pesel);
            if (pacjent != null)
            {
                Console.WriteLine("Znaleziono pacjenta:");
                pacjent.Wyswietl();
            }
            else
            {
                Console.WriteLine($"Błąd: Pacjent o PESEL {pesel} nie istnieje w bazie.");
            }
        }
    }
}
