using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        List<Discipline> disciplines = new List<Discipline>();
        public Form1()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                Lecturer lecturer = new Lecturer("Computer Science", "John Doe", "A101");
                Discipline discipline = new Discipline("Computer Programming", 1, 2, "ПОИТ", 10, 5, "экзамен", lecturer);

                Lecturer lecturer1 = new Lecturer("Department Science", "John Doe", "A101");
                Lecturer lecturer2 = new Lecturer("Department Lecture ", "Jane Smith", "B202");

                // Создание объектов класса Discipline
                Discipline discipline1 = new Discipline("Mathematics", 1, 1, "ПОИТ", 2, 2, "экзамен", lecturer1);
                Discipline discipline2 = new Discipline("Physics", 2, 2, "ДЭВИ", 2, 1, "зачет", lecturer2);*/

                 Lecturer lecturer = new Lecturer(departmentTextBox.Text, fullNameTextBox.Text, classroomTextBox.Text);
                  Discipline discipline = new Discipline(titleTextBox.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, 
                  specializationTextBox.Text, (int)numericUpDown3.Value,
                 (int)numericUpDown4.Value, controlTypeTextBox.Text,lecturer);

                disciplines.Add(discipline);
                richTextBox1.AppendText(discipline.ToString() + "\n");
                /*disciplines.Add(discipline1);
                richTextBox1.AppendText(discipline1.ToString() + "\n");
                disciplines.Add(discipline2);
                richTextBox1.AppendText(discipline2.ToString() + "\n");*/
            }
            catch (ArgumentException ex)
            {
                errorProvider1.SetError(button1, ex.Message);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(button1, "Произошла ошибка: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string searchQuery = textBox1.Text;

                richTextBox2.Clear();

                if (searchQuery.StartsWith("@"))
                {
                    string regexPattern = searchQuery.Substring(1); // Удаляем символ "@" из начала строки
                    Regex regex = new Regex(regexPattern, RegexOptions.IgnoreCase);

                    // Выполняем поиск по регулярному выражению во всех полях
                    List<Discipline> searchResults = disciplines.Where(d =>
                        regex.IsMatch(d.Title) ||
                        regex.IsMatch(d.Lecturer.FullName) ||
                        regex.IsMatch(d.Semester.ToString()) ||
                        regex.IsMatch(d.Course.ToString())
                    ).ToList();

                    // Сортируем результаты по количеству лекций и виду контроля
                    searchResults = searchResults.OrderBy(d => d.LectureCount).ThenBy(d => d.ControlType).ToList();

                    // Отображаем результаты поиска в RichTextBox
                    foreach (Discipline discipline in searchResults)
                    {
                        richTextBox2.AppendText(discipline.ToString() + Environment.NewLine);
                    }
                }
                else
                {
                    // Выполняем поиск на полное соответствие
                    List<Discipline> searchResults = disciplines.Where(d =>
                        d.Title.Equals(searchQuery) ||
                        d.Lecturer.FullName.Equals(searchQuery) ||
                        d.Semester == int.Parse(searchQuery) ||
                        d.Course == int.Parse(searchQuery)
                    ).ToList();

                    // Сортируем результаты по количеству лекций и виду контроля
                    searchResults = searchResults.OrderBy(d => d.LectureCount).ThenBy(d => d.ControlType).ToList();

                    // Отображаем результаты поиска в RichTextBox
                    foreach (Discipline discipline in searchResults)
                    {
                        richTextBox2.AppendText(discipline.ToString() + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            { //throw ex; }
            }
        }

        

        
    }
}
