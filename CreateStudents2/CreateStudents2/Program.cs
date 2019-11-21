﻿using System;

namespace CreateStudents2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            Student second = new Student();
            Student third = new Student(456, "Marco", 2.4);
            Student fourth = new Student();
            first.IdNumber = 123;
            first.LastName = "Anderson";
            first.GradePointAverage = 3.5;
            second.IdNumber = 789;
            second.LastName = "Daniels";
            second.GradePointAverage = 4.1;
            Display(first);
            Display(second);
            Display(third);
            Display(fourth);
        }
        static void Display(Student stu)
        {
            Console.WriteLine("{0, 5} {1, -10}{2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
        }
    }
    class Student
    {
        private double gradePointAverage;
        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;
        public int IdNumber { get; set; }
        public string LastName { get; set; }
        public double GradePointAverage
        {
            get
            {
                return gradePointAverage;
            }
            set
            {
                if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                {
                    gradePointAverage = value;
                }
                else
                {
                    gradePointAverage = LOWEST_GPA;
                }
            }
        }
        public Student(int id, string name, double gpa)
        {
            IdNumber = id;
            LastName = name;
            GradePointAverage = gpa;
        }
        public Student() : this(0, "XXX", 0.0) { }
    }
}
