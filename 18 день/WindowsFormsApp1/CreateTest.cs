using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class CreateTest : Form
    {
        private List<Question> questions = new List<Question>();
        public CreateTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string answer = textBox2.Text;

            // Создание объекта вопроса и добавление его в список
            Question question = new Question(text, answer);
            questions.Add(question);

            // Очистка полей ввода
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(questions, Formatting.Indented);
            File.WriteAllText("questions.json", json);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("questions.json"))
            {
                File.WriteAllText("questions.json", string.Empty);
            }
        }
    }
}
