class Program
{
    // Zadanie 1 - Napisz program, który posiada metodę statyczną, obliczaącą długość odcinka |AB| na podstawie współrzędnych punktów A i B.
    // A = (x1, y1), B = (x2, y2)
    // |AB| = √((x2 - x1)² + (y2 - y1)²)
    //static double ObliczDlugosc(double x1, double x2, double y1, double y2)
    //{
    //    return Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2 - y1, 2));
    //}

    //static void Main(string[] args)
    //{
    //    double x1 = -6, y1 = 1, x2 = -2, y2 = 4;
    //    Console.WriteLine(ObliczDlugosc(x1, x2, y1, y2));
    //    Console.ReadKey();
    //    //Console.WriteLine($"Długość odcinka |AB| dla punktów A({x1},{y1}) i B({x2},{y2}) wynosi: {ObliczDlugosc(x1, x2, y1, y2)}");
    //}

    // Zadanie 2 - Napisz program, zawierający metodę statyczną, która dla podanego (jako argumenty) tekstu zwraca tekst bez cyfr (jęśli w tekście występują cyfry).
    // a podnadto, jako argument out, udostępnia wartość liczby, która jest sumą wystepujących w tekście cyfr..
    // Przykładowow, gdyby argumentem był tekst "dom123", to metoda zwróciłaby tekst "dom", a wartość out byłaby równa 6 (1 + 2 + 3 = 6).
    static string UsunCyfry(string tekst, out int suma)
    {
        string TekstWynikowy = String.Empty; // inicjalizacja pustego tekstu
        suma = 0; // inicjalizacja sumy cyfr
        foreach (char znak in tekst)
        {
            if (znak >= '0' && znak <= '9') // Sprawdzenie czy znak jest cyfrą
                suma += znak - '0'; // konwersja znaku na wartość liczbową i dodanie do sumy
            else
                TekstWynikowy += znak; // dodanie znaku do tekstu wynikowego
        }
        return TekstWynikowy;
    }

    static void Main(string[] args)
    {
        int suma;
        Console.WriteLine(UsunCyfry("dom123", out suma));
        Console.WriteLine($"Suma cyfr wynosi: {suma}");
        Console.ReadKey();
    }

}