using System;

class Program
{


    static void Main(string[] args)
    {
        string cwd = Directory.GetCurrentDirectory();
        string fileName = "journal.txt";
        string fileString = $"{cwd}/{fileName}";
        Console.WriteLine(fileName);
        Console.WriteLine("Welcome to the Journal Program!");
        int userInput = -1;
        Journal journal = new Journal();

        while (userInput != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string userInputStr = Console.ReadLine();
            userInput = int.Parse(userInputStr);

            if (userInput == 1)
            {
                Entry entry = new Entry();
                string _entryPrompt = entry.DisplayPrompt();
                string entryText = Console.ReadLine();
                entry._entryText = entryText;
                string fullEntryString = entry.DisplayFullEntry(_entryPrompt);
                journal.AddEntry(fullEntryString, fileString, fileName);


            }
            if (userInput == 2)
            {
                journal.ShowAllEntries(fileString);
            }
            if (userInput == 3)
            {
                fileName = journal.Load();
                fileString = $"{cwd}/{fileName}";
            }
            if (userInput == 4)
            {
                fileName = journal.Save(fileName);
                fileString = $"{cwd}/{fileName}";
            }

        }


    }
}