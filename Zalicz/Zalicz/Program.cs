using Zalicz;

class Program { 
    static void Main(string[] args)
 {
        // Krok 1 & 2: Liczba przedmiotów i tworzenie obiektu
     Console.Write("Podaj liczbę przedmiotów: ");
    int n = int.Parse(Console.ReadLine());
    Swiadectwo s = new Swiadectwo(n);

    // Krok 3: Wprowadzanie danych
    s.Wczytaj();

    // Krok 5: Wyświetlenie wyników
    Console.WriteLine($"\nPromocja: {(s.Promocja() ? "TAK" : "NIE")}");
    if (s.Promocja())
        Console.WriteLine($"Średnia: {s.Srednia():F2}");
}
    }