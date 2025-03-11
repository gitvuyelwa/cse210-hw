using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Google";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Program Manager";
        job2._company = "Microsoft";
        job2._startYear = 2018;
        job2._endYear = 2020;
    
        Console.WriteLine($"{job1._company}\n{job2._company}");
    }
}