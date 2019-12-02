using System;

namespace ConferencesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Conference[] conferences = GetConferences(5);
            DisplayConferences(conferences);
            Array.Sort(conferences);
            Console.WriteLine("Sorted Conferences: ");
            DisplayConferences(conferences);
        }
        private static void DisplayConferences(Conference[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("Conference {0}: ", i);
                Console.WriteLine("\tName: {0}, Date: {1}, Attendees: {2}", arr[i].Name, arr[i].Date, arr[i].Attendees);
            }
        }
        private static Conference[] GetConferences(int count)
        {
            Conference[] conferenceArray = new Conference[count];
            for (int i = 0; i < count; ++i)
            {
                Console.Write("Name of conference {0}: ", i);
                string name = Console.ReadLine();
                Console.Write("Date of conference {0}: ", i);
                string date = Console.ReadLine();
                Console.WriteLine("Attendees of conference {0}: ", i);
                int attendees = GetAttendees();
                conferenceArray[i] = new Conference(name, date, attendees);
            }
            return conferenceArray;
        }

        private static int GetAttendees()
        {
            bool tmp = false;
            int attendees = 0;
            while(!tmp)
            {
                Console.Write("\tEnter a valid number");
                tmp = int.TryParse(Console.ReadLine(), out attendees);
            }
            return attendees;
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
