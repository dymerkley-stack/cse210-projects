using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Barnes and Noble";
        job1._startYear = 2015;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Water Slide Tester";
        job2._company = "6 Flags";
        job2._startYear = 2019;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Ryan Gosling";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}