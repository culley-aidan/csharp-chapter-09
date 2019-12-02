using System;

namespace DemoJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Job[] jobs = GetJobs(5);
            DisplayJobs(jobs);
        }
        private static void DisplayJobs(Job[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("Job \"{0}:\" ", arr[i].Description);
                Console.WriteLine("\tTime: {0}, Rate: {1}, Expected Fee: {2:F}, Returned Fee: {3:F} ", arr[i].Time, arr[i].Rate, (arr[i].Rate * arr[i].Time), arr[i].Fee);
            }
        }
        private static Job[] GetJobs(int count)
        {
            Job[] jobArray = new Job[count];
            string[] jobDescriptions = new string[] { "walking the dog", "painting the house", "patching the roof", "building a pool", "feeding the children", "watering the plants", "petting the cat", "shredding the documents", "stopping the pending investigation", "making children disappear", "washing the money", "selling consumable goods" };
            Random rng = new Random();
            for (int i = 0; i < count; ++i)
            {
                Job tmp = new Job();
                tmp.Description = jobDescriptions[rng.Next(0, jobDescriptions.Length)];
                tmp.Time = rng.Next(0, 50);
                tmp.Rate = Math.Round(rng.Next(0, 50) + rng.NextDouble(), 2);
                jobArray[i] = tmp;
            }
            return jobArray;
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
