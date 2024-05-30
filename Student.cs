using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._2
{
    internal class Student
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public double GPA { get; set; }

        public Student(string studentId, string studentName, double gPA)
        {
            StudentId = studentId;
            StudentName = studentName;
            GPA = gPA;
        }
    }
}
