public class Resume()
{
    public string _name;
    public List<Job> _jobs = new ();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //go through the jobs
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}