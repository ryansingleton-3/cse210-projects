using System;

class Program
{

    public List<Prompt> _questions = new List<Prompt>();
    static void Main(string[] args)
    {
         

        Prompt prompt1 = new Prompt();
        prompt1._questions.add(prompt1);
    }
}

// class for entries and a class for prompts
// display method for each class
// entry attributes - str date/time, str entry text
// prompt attributes - str prompt text
