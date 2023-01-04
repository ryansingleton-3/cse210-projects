using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            string strInput = Console.ReadLine();
            userNumber = int.Parse(strInput);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");


    }
}