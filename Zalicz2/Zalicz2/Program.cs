namespace Zalicz2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicjalizacja dziennika
            Dziennik mojDziennik = new Dziennik();

            // 1. Dodaj kilku pacjentów
            Pacjent p1 = new Pacjent("Krzysztof", "bakiewicz", "90010112345");
            p1.DodajChorobe("Grypa");
            p1.DodajChorobe("Angina");

            Pacjent p2 = new Pacjent("Anna", "Noga", "95050554321");
            p2.DodajChorobe("Alergia");

            mojDziennik.DodajPacjenta(p1);
            mojDziennik.DodajPacjenta(p2);

            // 2. Wyświetl listę wszystkich pacjentów
            mojDziennik.WyswietlWszystkichPacjentow();

            // 3. Znajdź pacjenta po PESEL
            mojDziennik.ZnajdzPacjenta("90010112345");

            // Opcjonalnie: Test usunięcia
            // mojDziennik.UsunPacjenta("95050554321");

            Console.ReadKey();
        }
    }
}