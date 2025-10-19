class Program
{
    //// Zadanie 1 - Napisz program, który oblicza sumę liczb od 1 do 100
    //static void Main(string[] args)
    //{
    //    int suma = 0;
    //    for (int i = 1; suma <= 100; i++)
    //    {
    //        suma += i;
    //        Console.WriteLine($"Suma{i,3}, Aktualna suma: {suma,3}");
    //    }
    //    Console.WriteLine();
    //    Console.WriteLine($"\nCałkowita suma:  {suma,3}");
    //}

    // Inne rozwiązanie zadania 1 - użycie pętli while
    //static void Main(string[] args)
    //{
    //    int suma = 0, licznik = 0;
    //    while (suma < 100)
    //    {
    //        licznik++;
    //        suma += licznik;
    //        Console.WriteLine("Dodano {0}, liczb. Aktualna suma: {1}", licznik, suma);
    //    }
    //    Console.ReadKey();
    //}
    // Zadanie 2 - Napisz program, który w pętli prosi użytkownika o podanie roku, a następnie sprawdza, czy dany rok jest rokiem przestępnym.
    // Program ma się zakończyć, gdy użytkownik zapytany i chęć sprawdzenia kolejnego roku odpowie "n".
    // Rokk przestępny to rok podzielny przez 4, ale niepodzielny przez 100, chyba że jest podzielny przez 400.
    //    static void Main(string[] args)
    //    {
    //        string koniec = "n";
    //        do
    //        {
    //            Console.Write("Podaj rok: ");
    //            int rok = int.Parse(Console.ReadLine());
    //            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
    //            {
    //                Console.WriteLine("Rok {0} jest rokiem przestępnym.", rok);
    //            }
    //            else
    //            {
    //                Console.WriteLine("Rok {0} nie jest rokiem przestępnym.", rok);
    //                Console.Write("Czy chcesz sprawdzić inny rok? (t/n): ");
    //                koniec = Console.ReadLine();
    //            }

    //        } while (koniec != "n");
    //    }
    //}
    // Zadanie 3 - Dysponując monetami o nominałach 1,2,5, sprawdz na ile rożnych sposobów można wypłaicić 10 zł. 
    // Napisz program, który wypisze wszystkie możliwe kombinacje oraz liczbę tych kombinacji.
    //static void Main(string[] args)
    //{
    //    int liczbaKombinacji = 0;
    //    for (int i = 0; i <= 10; i++) // liczba monet 5zł
    //    {
    //        for (int j = 0; j <= (10 - i * 5) / 2; j++) // liczba monet 2zł
    //        {
    //            for (int k = 0; k <= 10 - i * 5 - j * 2; k++) // liczba monet 1zł
    //            {
    //                if (i * 5 + j * 2 + k * 1 == 10)
    //                {
    //                    liczbaKombinacji++;
    //                    Console.WriteLine($"5zł: {i}, 2zł: {j}, 1zł: {k}");
    //                }
    //            }
    //        }
    //    }
    //    Console.WriteLine($"\nLiczba wszystkich kombinacji: {liczbaKombinacji}");
    //}

 