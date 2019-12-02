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

        public Job(string description, double time, double rate)
        {
            Description = description;
            Time = time;
            Rate = rate;
        }

        public Job() => new Job("", 0, 0);
    }
}
