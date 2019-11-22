using System;

namespace TilingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Room[] roomArray = new Room[10];
            for(int i = 0; i < 10; ++i)
            {
                roomArray[i] = new Room(11.05D, 11.05D);
            }
            Display(roomArray);
        }
        static void Display(Room[] rooms)
        {
            foreach(Room rm in rooms)
            {
                Console.WriteLine("Length: {0}{3}Width: {1}{3}Boxes of tile: {2}{3}", rm.Length, rm.Width, rm.BoxTotal, Environment.NewLine);
            }
        }
    } 
    class Room
    {
        public double Length { get; set; }
        public double Width { get; set; }
        private readonly double area;
        private int boxes()
        {
            int returnValue = (int)area / 12;
            if (area % 12 != 0)
            {
                ++returnValue;
            }
            ++returnValue;
            return returnValue;
        }
        public int BoxTotal { get => boxes(); } 
        public Room(double length, double width)
        {
            Length = length;
            Width = width;
            area = length * width;
        }
        public Room() => new Room(0, 0);
    }
}
