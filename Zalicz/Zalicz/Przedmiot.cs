using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalicz
{
    public class Przedmiot
    {
        private string nazwa;
        private int ocena; // 0=brak, 2=ndst, 3=dst, 4=db, 5=bdb

        // Konstruktory: domyślny i z parametrami
        public Przedmiot() { nazwa = ""; ocena = 0; }
        public Przedmiot(string nazwa, int ocena) { this.nazwa = nazwa; this.ocena = ocena; }

        // Metoda zwracająca ocenę (potrzebna do obliczeń w klasie Swiadectwo)
        public int Ocena() => ocena;

        // Interakcja: wczytywanie danych od użytkownika
        public void Wczytaj()
        {
            Console.Write("Nazwa przedmiotu: "); nazwa = Console.ReadLine();
            Console.Write("Ocena (0, 2-5): "); ocena = int.Parse(Console.ReadLine());
        }
    }
}
