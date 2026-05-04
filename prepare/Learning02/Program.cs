using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        // public class Resume
        // {
        //     public string _name;
        //     public List<Job> _jobs = new List<Job>();
        // }

        Job job1 = new Job(); 
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2024;


        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Technician";
        job2._startYear = 2024;
        job2._endYear = 2025;

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);
        // job1.Display();
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Kale is s";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //  Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.Display();
    }
}