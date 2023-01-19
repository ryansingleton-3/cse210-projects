using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._name = "OMG Commerce";
        job1._jobTitle = "Amazon Lead Specialist";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._name = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume resume = new Resume();
        resume._personName = "Ryan Singleton";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}