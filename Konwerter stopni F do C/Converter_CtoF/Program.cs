class Program
{
    static void Main(string[] args)
    {
        // Przeliczanie stopnie Fahrenheita na stopnie Celsjusza
        double F, C;   
        Console.WriteLine("Podaj temperaturę w stopniach Fahrenheita: ");
        F =double.Parse(Console.ReadLine());
        C= (F - 32) * 5 / 9;    
        Console.WriteLine("Temperatura w stopniach Celsjusza wynosi: " + C);
        Console.ReadKey();  
    }
}