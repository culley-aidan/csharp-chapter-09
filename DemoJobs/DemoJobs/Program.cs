using System;

namespace DemoJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Job
    {
        public string Description { get; set; }
        public double Time { get; set; }
        public double Rate { get; set; }
        public double Fee { get => Time * Rate; }

        public static Job operator+ (Job x, Job y)
        {
            Job tmp = new Job();
            tmp.Description = string.Format("{0} and {1}", x.Description, y.Description);
            tmp.Time = x.Time + y.Time;
            tmp.Rate = (x.Rate + y.Rate) / 2;
            return tmp;
        }

        public Job(string description, double time, double rate)
        {
            Description = description;
            Time = time;
            Rate = rate;
        }

        public Job() => new Job("", 0, 0);
    }
}
