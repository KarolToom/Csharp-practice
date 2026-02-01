using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalicz
{
    public class Swiadectwo
    {
        private int ile;
        private Przedmiot[] przedmioty; // Agregacja obiektów klasy Przedmiot

        public Swiadectwo(int liczba)
        {
            ile = liczba;
            przedmioty = new Przedmiot[ile];
            for (int i = 0; i < ile; i++) przedmioty[i] = new Przedmiot();
        }

        // Konstruktor kopiujący (wymagany w treści)
        public Swiadectwo(Swiadectwo wzorzec)
        {
            this.ile = wzorzec.ile;
            this.przedmioty = (Przedmiot[])wzorzec.przedmioty.Clone();
        }

        public void Wczytaj()
        {
            for (int i = 0; i < ile; i++)
            {
                Console.WriteLine($"\nPrzedmiot {i + 1}:");
                przedmioty[i].Wczytaj();
            }
        }
        public double Srednia()
        {
            var ocenione = przedmioty.Where(p => p.Ocena() > 0).ToList();
            if (ocenione.Count == 0) return 0;
            return Math.Round(ocenione.Average(p => p.Ocena()), 2);
        }

        public bool Promocja()
        {
            // Jeśli jakikolwiek przedmiot ma ocenę 2, zwróć false
            return !przedmioty.Any(p => p.Ocena() == 2);
        }

    }
}
