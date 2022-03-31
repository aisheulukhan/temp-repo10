using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask3.Models
{
    class Group
    {
        private int _groupno;
        private int _studentlimit;
        public int GroupNo { get; set; }
        public int StudentLimit
        {
            get
            {
                return _studentlimit;
            }
            set
            {
                if (value < 5 || value > 18)
                {
                    _studentlimit = value;
                }
            }
        }
        private Student[] _students = new Student[0];
        public Student this[int index]
        {
            get { return _students[index]; }
            set { _students[index] = value; }
        }
        public void AddStudent(Student student)
        {
            if (_students.Length < StudentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Limiti kecdiniz!");
            }
        }
        public bool CheckGroupNo(string groupNo)
        {
            bool isupper1 = false;
            bool isupper2 = false;
            bool isdigit3 = false;
            bool isdigit4 = false;
            bool isdigit5 = false;
            if (groupNo.Length >= 5)
            {
               
                    if (char.IsUpper(groupNo[0])) isupper1 = true;
                    if (char.IsUpper(groupNo[1])) isupper2 = true;
                    if (char.IsDigit(groupNo[2])) isdigit3 = true;
                    if (char.IsDigit(groupNo[3])) isdigit4 = true;
                    if (char.IsDigit(groupNo[4])) isdigit5 = true;

                if (isupper1 && isupper2 && isdigit3 && isdigit4 && isdigit5) return true;
            }
            return false;

        }
        public void GetStudent(int? StudentId)
        {
            if (StudentId != null)
            {
                foreach (Student student in _students)
                {
                    if (student.Id == StudentId)
                    {
                        Console.WriteLine(student);
                    }
                }
            }
        }
        public void GetAllStudents()
        {
            foreach (var item in _students)
            {
                Console.WriteLine(item);
            }
        }
        public Group(int groupno, int studentlimit)
        {
            GroupNo = groupno;
            StudentLimit = studentlimit;
        }
    }
}
