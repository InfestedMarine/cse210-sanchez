using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "Level Designer";
        job1._company = "Valve.Corp";
        job1._startYear = 2005;
        job1._endYear = 2015;

        Resume myResume = new Resume();
        myResume._name = "Cyan D. Sanchez";

        job job2 = new job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = 2019;
        job2._endYear = 2022;

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}
