using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1.Classes;
using System.IO;
using System.Text.Json;


namespace WindowsFormsApp1
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Entercs newForm = new Entercs();
            this.Hide();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string login = LoginTextBox.Text;
            string password = textBox1.Text;
            string repeater = textBox2.Text;

            if (password == repeater)
            {
                Student student = new Student(name, login, password);

                // Загрузка списка существующих пользователей из файла (если файл существует)
                List<Student> existingStudents = LoadStudents();

                // Добавление нового пользователя в список
                existingStudents.Add(student);

                // Сохранение обновленного списка в файл
                SaveStudents(existingStudents);

                textBox1.Text = "";
                textBox2.Text = "";

                MessageBox.Show("Студент зарегистрирован!");
            }
            else
            {
                MessageBox.Show("Не совпадают пароли!");
            }
        }

        private List<Student> LoadStudents()
        {
            List<Student> students = new List<Student>();

            try
            {
                if (File.Exists("students.json"))
                {
                    string jsonString = File.ReadAllText("students.json");
                    students = JsonSerializer.Deserialize<List<Student>>(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке списка студентов: " + ex.Message);
            }

            return students;
        }

        private void SaveStudents(List<Student> students)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(students);
                File.WriteAllText("students.json", jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении списка студентов: " + ex.Message);
            }
        }
    }
}