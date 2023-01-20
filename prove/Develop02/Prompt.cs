public class Prompt
{
    public string _question = "";

    public string _questions;
    public List<Job> _jobs = new List<Job>();

    
    public Prompt()
    {

    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_name}) {_startYear}-{_endYear}");
    }


}