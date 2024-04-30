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
using System.Text.Json;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Entercs : Form
    {
        private List<Student> students; // Список студентов

        public Entercs()
        {
            InitializeComponent();
            LoadStudents(); // Загрузка списка студентов при инициализации формы
        }

        private void LoadStudents()
        {
            try
            {
                if (File.Exists("students.json"))
                {
                    string jsonString = File.ReadAllText("students.json");
                    students = JsonSerializer.Deserialize<List<Student>>(jsonString);
                }
                else
                {
                    students = new List<Student>(); // Создание нового списка, если файл не существует
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке списка студентов: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Ничего не делаем
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm newForm = new RegForm();
            this.Hide();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = textBox1.Text;

            bool loginSuccessful = Login(login, password);

            if (login == "admin" && password == "admin")
            {
                CreateTest newForm = new CreateTest();
                this.Hide();
                newForm.Show();
            }
            else if (loginSuccessful)
            {
                Test newForm = new Test();
                //this.Hide();
                newForm.Show();
            }
            else
            {
                // Неверный логин или пароль
                MessageBox.Show("Неверный логин или пароль!");
            }

            // Очистка текстовых полей после входа
            
        }

        private bool Login(string login, string password)
        {
            foreach (Student student in students)
            {
                if (student.Enter(login, password))
                {
                    return true; // Верные логин и пароль
                }
            }

            return false; // Неверные логин или пароль
        }
    }
}