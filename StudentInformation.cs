using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4._2
{
    public partial class StudentInformation : Form
    {
        BindingList<Student> students = new BindingList<Student>();
        public StudentInformation()
        {
            InitializeComponent();
            StudentsListBox.DataSource = students;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(StudentIdBox.Text) || String.IsNullOrEmpty(StudentNameBox.Text) || String.IsNullOrEmpty(GPABox.Text))
            {
                MessageBox.Show("Enter Valid input in all fields");
            }
            else
            {
                Student student1 = new Student(StudentIdBox.Text, StudentNameBox.Text, Convert.ToDouble(GPABox.Text));
                students.Add(student1);
                MessageBox.Show("Student added");
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int indexSelect = StudentsListBox.SelectedRows[0].Index;
            students.RemoveAt(indexSelect);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("C:\\Tests\\test.txt"))
            {
                List<Student> studentsList = new List<Student>();
                studentsList = students.ToList();
                List<Student> orderedStudentList = studentsList.OrderByDescending(x => x.GPA).ToList();
                sw.WriteLine(orderedStudentList[0].StudentId+" "+ orderedStudentList[0].StudentName+ " "+ orderedStudentList[0].GPA);
                students.Clear();
                foreach (var student in orderedStudentList)
                {
                    students.Add(student);
                }
            }
        }
    }
}
