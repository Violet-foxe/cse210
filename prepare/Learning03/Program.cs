using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 7);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
        
        Fraction fraction = new Fraction();
        Random rnd = new Random();

        for (int i=0; i<30; i++) 
        {
            int top = rnd.Next(1,13);
            int bottom = rnd.Next(1,13);

            fraction.SetTop(top);
            fraction.SetBottom(bottom);

            Console.Write($"String {i+1}: {fraction.GetFractionString()}, ");
            Console.WriteLine($"Decimal {i+1}: {fraction.GetDecimalValue()}\n");
        }
    }
}