public class Resume
{
    public string _personName = "";
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {

    }

    public void Display()
    {
        Console.WriteLine($"{_personName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }


}