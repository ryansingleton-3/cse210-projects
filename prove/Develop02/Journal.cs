using System;
using System.IO;
public class Journal
{
    // attributes: List of all entries
    public List<Entry> _entries = new List<Entry>();
    
    public Journal()
    {

    }

    // methods: Save, Load, Add Entry, Show all entries
    public void AddEntry(string fullEntryString, string fileString, string fileName)
    {
        // File.CreateText(fileName);
        File.AppendAllText(fileName, fullEntryString + Environment.NewLine);
                     
    }
    public void ShowAllEntries(string fileString)
    {
        string line;
        using (StreamReader file = new StreamReader(fileString))
        {
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    public string Save(string currentFileName)
    {
        Console.Write("What would you like to name your file?");
        string newFileName = Console.ReadLine();
        File.Move(currentFileName, newFileName);
        return newFileName;
    }
    public string Load()
    {
        Console.Write("What is the name of the file you would like to load?");
        string newFileName = Console.ReadLine();
        return newFileName;
        
        
    }

}