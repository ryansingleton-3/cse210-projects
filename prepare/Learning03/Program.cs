using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstFraction = new Fraction();
        Fraction secondFraction = new Fraction(6);
        Fraction thirdFraction = new Fraction(6,7);
        Console.WriteLine(firstFraction.GetFractionString());
        Console.WriteLine(firstFraction.GetDecimalValue());
        Console.WriteLine(secondFraction.GetFractionString());
        Console.WriteLine(secondFraction.GetDecimalValue());
        Console.WriteLine(thirdFraction.GetFractionString());
        Console.WriteLine(thirdFraction.GetDecimalValue());


    }
}