using System;

namespace ConferencesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Conference : IComparable
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Attendees { get; set; }
        public int CompareTo(object obj)
        {
            if (obj == null) {
                return 1;
            }
            Conference conference = obj as Conference;
            if (conference != null)
            {
                return Attendees.CompareTo(conference.Attendees);
            } else {
                throw new ArgumentException("object is not a conference");
            }
        }

        public Conference(string name, string date, int attendees)
        {
            Name = name;
            Date = date;
            Attendees = attendees;
        }

        public Conference() => new Conference("", "", 0);
    }
}
