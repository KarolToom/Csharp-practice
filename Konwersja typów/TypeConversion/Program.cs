class Program
{     static void Main(string[] args)
    {
      const int liczbaMiesiecy = 12; //
        int liczbaSamochodow;
        double sredniaSprzedaz;
        Console.WriteLine("Podaj liczbe samochodow sprzedanych w ciagu roku:");
        liczbaSamochodow = Convert.ToInt32(Console.ReadLine());  //liczbaSamochodow =- int.Parse(Console.ReadLine());
        sredniaSprzedaz= (double)liczbaSamochodow / liczbaMiesiecy; // tutaj zmieniamy int na double aby wynik dzielenia byl w formacie zmiennoprzecinkowym
        Console.WriteLine($"Srednia miesieczna sprzedaz samochodow wynosi: {sredniaSprzedaz}");
        Console.ReadKey();

    }
}