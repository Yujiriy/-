using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            students.Add(new Student("Вася", "Петров", "П17", "Удовлитворительно"));
            students.Add(new Student("Петр", "Васильев", "П17", "Ну такое"));
            students.Add(new Student("Юрий", "Бобрикович", "П17", "ура"));
            DisplayStudents(students);
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string group = groupTextBox.Text;
            string gpa = gpaTextBox.Text;

            Student newStudent = new Student(name, surname, group, gpa);
            students.Add(newStudent);

            MessageBox.Show("Студент успешно добавлен!");

            ClearInputs();
            DisplayStudents(students);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchCriteria = searchTextBox.Text;

            List<Student> searchResults = students.FindAll(student =>
                student.Name.Contains(searchCriteria) ||
                student.Surname.Contains(searchCriteria) ||
                student.Group.Contains(searchCriteria) ||
                student.GPA.ToString().Contains(searchCriteria));


            if (searchResults.Count > 0)
            {
                DisplayStudents(searchResults);
            }
            else
            {
                MessageBox.Show("Студенты не найдены!");
            }
        }

        private void DisplayStudents(List<Student> studentsList)
        {
            studentsListBox.Items.Clear();

            foreach (Student student in studentsList)
            {
                studentsListBox.Items.Add(student);
            }
        }

        private void ClearInputs()
        {
            nameTextBox.Clear();
            surnameTextBox.Clear();
            groupTextBox.Clear();
            gpaTextBox.Clear();
        }

        public class Student
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Group { get; set; }
            public string GPA { get; set; }

            public Student(string name, string surname, string group, string gpa)
            {
                Name = name;
                Surname = surname;
                Group = group;
                GPA = gpa;
            }

            public override string ToString()
            {
                return $"{Surname} {Name}, Группа: {Group}, Успеваемость: {GPA}";
            }
        }

        private void gpaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}