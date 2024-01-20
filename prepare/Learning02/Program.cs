using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume1 = new();
        resume1._firstName = "John";
        resume1._lastName = "Doe";

        Job job1 = new Job("Microsoft", "Engineer", 2010, 2020, 80000);
        Job job2 = new Job("Microsoft", "Engineer", 2010, 2020, 80000);
        Job job3 = new Job("Microsoft", "Engineer", 2010, 2020, 80000);
        job2._company = "Apple";
        job3._endYear = 2021;
        resume1.AddJob(job1);
    }
}