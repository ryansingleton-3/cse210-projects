public class Entry
{
    // Attributes: date, text string
    public string _entryText = "";
    public string _entryPrompt = "";

    public List<string> promptList = new List<string>{
	    "Who was the most interesting person I interacted with today?", "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?", "What am I grateful for?", "What is one thing I was excited to do today?"};
    

    
    public Entry()
    {

    }


    // methods: display

    public string DisplayPrompt()
    {
        Random random = new Random ();
        int promptIndex = random.Next(promptList.Count);
        string _entryPrompt = promptList[promptIndex];
        Console.WriteLine(_entryPrompt);
        Console.WriteLine("");
        return _entryPrompt;

    }
    public string DisplayFullEntry(string _entryPrompt)
    {
        DateTime date = DateTime.Now;
        date.ToShortDateString();
        string fullEntryString = $"Prompt: {_entryPrompt} - Entry: {_entryText} - Date: {date}";
        return fullEntryString;
    }


}