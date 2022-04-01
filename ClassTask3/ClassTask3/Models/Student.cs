using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask3.Models
{
    class Student
    {
        private static int _id;
        private string _fullName;
        private double _point;
        public int Id
        {
            get;
        }
        static Student()
        {
            _id = 0;
        }
        public Student(string fullname, double point)
        {
            _id++;
            Id = _id;
        }
        public string FullName { get; set; }
        public int Point { get; set; }
        public Student(string fullname, int point) 
        {
            FullName = fullname;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id} FullName: {FullName}  Point: {Point}");
        }
    }
}
