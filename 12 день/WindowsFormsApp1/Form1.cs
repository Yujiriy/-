using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Alice", Age = 20, UniversityName = "University A" },
            new Student { Name = "Bob", Age = 22, UniversityName = "University B" },
            new Student { Name = "Charlie", Age = 21, UniversityName = "University A" },
            new Student { Name = "David", Age = 23, UniversityName = "University C" }
        };
        

        List<University> universities = new List<University>()
        {
            new University { Name = "University A", Location = "City X" },
            new University { Name = "University B", Location = "City Y" },
            new University { Name = "University C", Location = "City Z" }
        };

        public Form1()
        {
            InitializeComponent();
            foreach (var st in students)
                listBox1.Items.Add(st);

            foreach (var un in universities)
                listBox2.Items.Add(un);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var query = from student in students
                        join university in universities on student.UniversityName equals university.Name
                        select new { student.Name, student.Age, university.Location };

            // Выводим результат выборки
            foreach (var result in query)
            {
                richTextBox1.AppendText($"Name: {result.Name}, Age: {result.Age}, Location: {result.Location}\n" );
            }
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                Name = nameTextBox.Text,
                Age = (int)ageNumericUpDown1.Value,
                UniversityName = universityNameTextBox.Text
            };

            students.Add(student);
            listBox1.Items.Add(student);

            nameTextBox1.Text = universityNameTextBox.Text;

            nameTextBox.Clear();
            universityNameTextBox.Clear();

        }

        private void addUnivBtn_Click(object sender, EventArgs e)
        {   var university = new University { Location = locationTextBox.Text, Name = nameTextBox1.Text };
            listBox2.Items.Add(university);
            universities.Add(university);

            nameTextBox1.Clear();
            locationTextBox.Clear();
        }
    }
}
