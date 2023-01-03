using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number? ");
        // string magicNumStr = Console.ReadLine();
        // int magicNumber = int.Parse(magicNumStr);
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        int guess = -1;

        while ((guess != magicNumber))
        {
            Console.WriteLine("What your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
            Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
            Console.WriteLine("Lower");
            }
            else
            {
            Console.WriteLine("You guessed it!");
            }
        }
        

    }
}