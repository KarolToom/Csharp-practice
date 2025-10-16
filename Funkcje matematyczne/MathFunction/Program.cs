using System;
    class Program
{
    static void Main(string[] args)
    {
        double x, y;
        Console.WriteLine("Podaj x (większe od 0):");
        x= Convert.ToDouble(Console.ReadLine());
        y = Math.PI * Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0));
        Console.WriteLine($"y = {y}");
        Console.ReadKey();
    }
}