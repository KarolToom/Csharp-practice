class Program
{
     static void Main(string[] args)
    {
        // Założenie do programu. Program ma znaleźć liczby doskonałe w podanym zakresie.
        //W przedziale od <1, 10000>. Liczba doskonała to taka liczba,
        //która jest równa sumie swoich dzielników właściwych (mniejszych od niej samej).
        // np. 6 = 1 + 2 + 3, 28 = 1 + 2 + 4 + 7 + 14.
        int suma;
        for (int i=1; i <= 10000; i++)
        {
            suma = 0;
            for (int j = 1; j < i; j++)
            {
               suma += (i % j == 0) ? j : 0;
            }
            if (suma == i)
            {
                Console.WriteLine($"Liczba doskonała: {i}");
            }
        }
        Console.ReadKey();
    }
}