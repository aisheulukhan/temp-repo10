using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask3.Models
{
    class Group
    {
        private string _groupno;
        private int _studentlimit;
        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get
            {
                return _studentlimit;
            }
            set
            {
                if (value >= 5 || value <= 18)
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
                Console.WriteLine("Limit kecildi");
            }
        }
        public bool CheckGroupNo(string groupNo)
        {
            bool isUpper1 = false;
            bool isUpper2 = false;
            bool isDigit3 = false;
            bool isDigit4 = false;
            bool isDigit5 = false;
            if (groupNo.Length == 5)
            {

                if (char.IsUpper(groupNo[0])) isUpper1 = true;
                else return false;
                if (char.IsUpper(groupNo[1])) isUpper2 = true;
                else return false;
                if (char.IsDigit(groupNo[2])) isDigit3 = true;
                else return false;
                if (char.IsDigit(groupNo[3])) isDigit4 = true;
                else return false;
                if (char.IsDigit(groupNo[4])) isDigit5 = true;
                else return false;

                if (isUpper1 && isUpper2 && isDigit3 && isDigit4 && isDigit5) return true;
            }
            return false;

        }
        public void GetStudent(int? StudId)
        {
            if (StudId != null)
            {
                foreach (Student student in _students)
                {
                    if (student.Id == StudId)
                    {
                        Console.WriteLine(student.FullName);
                    }
                }
            }
        }
        public void GetAllStudents()
        {
            foreach (var item in _students)
            {
                Console.WriteLine(item.FullName);
            }
        }
        
    }
}
