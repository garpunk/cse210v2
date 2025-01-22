using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Browning";
        job1._jobTitle = "Machinist";
        job1._startYear = 2021;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "BYUI";
        job2._jobTitle = "Podcast Host";
        job2._startYear = 2024;
        job2._endYear = 2027;


        Resume resume1 = new Resume();
        resume1._name = "Garrett Helms";

        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);

        resume1.Display();

    }
   
}