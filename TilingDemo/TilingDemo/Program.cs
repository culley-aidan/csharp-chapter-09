using System;

namespace TilingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
        public int BoxTotal()
        {
            return boxes();
        }
        public Room(double length, double width)
        {
            Length = length;
            Width = width;
            area = length * width;
        }
        public Room() : this(0,0) { }
    }
}
