using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string letter;

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 600 && percentage < 70)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine(letter);

        if (percentage < 70)
        {
            Console.WriteLine("You did not pass the class. Maybe you will on the next attempt!");
        }
        else 
        {
            Console.WriteLine("You passed the class! Congratulations!");
        }


    }
}