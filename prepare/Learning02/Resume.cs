using System;

public class Resume
{

    public string _namePerson;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {

        Console.WriteLine($"Name: {_namePerson}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.DisplayJobDetails();
        }



    }

}