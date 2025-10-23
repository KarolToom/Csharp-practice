class Program
{
    // Zadanie 1 - Napisz program, ltóry deklaruje tablicę jednowymiarową z danymi typu int o rozmiarze podanym przez użytkownika.
    // Należy wpisać losowe wartośći do tablicy z zakresu od <1,10>.
    // Program ma wyśwwietlić wszystkie elementy tablicy oraz wartość najmniejszą i jej pozycję w tablicy.

    //static void Main(string[] args)
    //{
    //    int[] liczby;
    //    Console.Write("Podaj rozmiar: ");
    //    int rozmiar = int.Parse(Console.ReadLine());
    //    int minPozycja, minWartosc;
    //    liczby = new int[rozmiar];

    //    Random rand = new Random();
    //    for (int i = 0; i < liczby.Length; i++)
    //    {
    //        liczby[i] = rand.Next(1, 11);
    //        Console.Write("{0}, ", liczby[i]);
    //    }
    //    minPozycja = 0;
    //    minWartosc = liczby[0];
    //    for (int i=1; i<liczby.Length; i++)
    //    {
    //        if (liczby[i] < minWartosc)
    //        {
    //            minWartosc = liczby[i];
    //            minPozycja = i;
    //        }
    //    }
    //    Console.WriteLine();
    //    Console.WriteLine("Najmniejsza wartosc: {0}, na pozycji: {1}", minWartosc, minPozycja);
    //    Console.ReadKey();
    //}

    // Zadanie 2 - Napisz program, który deklaruję tablicę jednowymiarową o rozmiarze 5 inicjalizowaną w trakcie deklaracji wartościami typu int i zapełni ją elementami z tablicy,
    //  a następnie wstaw na sam początek listy nowy element - liczbę 0. Wyświetl elementy listy.

    //static void Main(string[] args)
    //{
    //    int[] liczby ={ 30,40,21,63,10,15 };
    //    List<int> listaLiczb = new List<int>();

    //    for (int i =0; i <liczby.Length; i++)
    //    {
    //        listaLiczb.Add(liczby[i]);
    //    }
    //    listaLiczb.Insert(0, 0);

    //    foreach(int pozycja in listaLiczb)
    //    {
    //        Console.WriteLine("{0}, ", pozycja);
    //    }

    //}

    // Zadanie 3 - Napisz program, który deklaruje tablicę dwuwmiarową o rozmiarze 4x4 liczbami rzeczywistymi.
    // Elementy macierzy należy umieśćić w trakcie deklaracji. Program ma wyświetlić elementy tablicy ( wiersz po wierszu), a następnie wyświetlić sumę elementów znajdujących się na głównej przekątnej tablicy.
    // (główna przekątna to elementy o indeksach [0,0], [1,1], [2,2], [3,3]) oraz sumę elementów znajdujących się na drugiej przekątnej.

    static void Main(string[] args)
    {
        int[,] macierz = {
        { 1, 2, 3, 4},
        { 5, 6, 7, 8},
        { 9, 10, 11, 12},
        { 13, 14, 15, 64}};
        int suma1 = 0, suma2 = 0;
        for (int i = 0; i < macierz.GetLength(0); i++)
        {
            for (int j = 0; j < macierz.GetLength(1); j++)
            {
                Console.Write("{0}", macierz[i, j]);
                if (i == j)
                {
                    suma1 += macierz[i, j];
                }

                if (i + j +1 == macierz.GetLength(1))
                {
                    suma2 += macierz[i, j];
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("Suma elementów na głównej przekątnej: {0}", suma1);
        Console.WriteLine("Suma elementów na drugiej przekątnej: {0}", suma2);
    }
}

