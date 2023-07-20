using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job { Company = "Microsoft", JobTitle = "Software Engineer", StartYear = 2019, EndYear = 2022 };
Job job2 = new Job { Company = "Apple", JobTitle = "Manager", StartYear = 2022, EndYear = 2023 };

Resume resume = new Resume { _name = "John Doe", _jobs = new List<Job> { job1, job2 } };

job1.Display();
job2.Display();
    }
}