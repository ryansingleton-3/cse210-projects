public class Job
{
    public string _name = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public Job()
    {

    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_name}) {_startYear}-{_endYear}");
    }


}