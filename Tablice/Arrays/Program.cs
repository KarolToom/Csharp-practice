class Program
{
    // Tablice wielowymiarowe

    //   static void Main(string[] args)
    //{
    //    int[,] tab = new int[3, 4];
    //    Random rand = new Random();
    //    for (int i=0; i< tab.GetLength(0); i++)
    //    {
    //     for (int j=0; j< tab.GetLength(1); j++)
    //        {
    //            tab[i, j] = rand.Next(1, 100);
    //            Console.Write($"{tab[i, j]} \t"); // Console.Write("{0,4} ", tab[i, j]);

    //        }
    //        Console.WriteLine();
    //    }
    //    Console.ReadKey();
    //}

    // Tablice nieregularne cz 1

    //static void Main(string[] args)
    //{
    //    int[][] tab = {new int[] {1,2 }
    //                    , new int[] {3,4,5 }
    //                    , new int[] {6,7,8,9 } };
    //    Console.WriteLine("Tablica nieregularna tab[1][2]={0}:", tab[2][2]);
    //    foreach (int[] wiersz in tab)
    //    {
    //        foreach (int element in wiersz)
    //        {
    //            Console.Write("{0,2}", element);
    //        }
    //        Console.WriteLine();
    //    }
    //    Console.ReadKey();
    //}

    // Tablice nieregularne cz 2
    static void Main(string[] args)
    {
        string[][] zespoly = {
                new string[] { "Jan", "Olek" },
                new string[] { "Kasia", "Ela", "Tomek", "Jarek" },
                new string[] { "Adam", "Robert", "Zofia" } };
        for (int i = 0; i < zespoly.Length; i++)
        {
            for (int j = 0; j < zespoly[i].Length; j++)
            {
                Console.Write("{0,-8}", zespoly[i][j]);
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}