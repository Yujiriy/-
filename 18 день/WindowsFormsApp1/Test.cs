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
    public partial class Test : Form
    {
        public DistanceExamenator exam = new DistanceExamenator();
        private int currentQuestionIndex = 0;
        public int mark = 0;
       
        public Test()
        {
            InitializeComponent();
            exam.Load(); 
            DisplayQuestion();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadQuestions()
        {
           
        }

        private void DisplayQuestion()
        {
            if (exam.questions != null && currentQuestionIndex < exam.questions.Count)
            {
                lblQuestion.Text = exam.questions[currentQuestionIndex].GetText();
                txtUserAnswer.Clear();
                lblStatus.Text = "";
                
            }
            else
            {
                MessageBox.Show($"Вопросы закончились! Оценка {mark}");

                
                
                exam.currentUser = exam.FindUser("va", "va");
                exam.currentUser.questionCount = exam.questions.Count;
                exam.currentUser.rightAnswers = mark;
                exam.Save();
                button1.Enabled = false;
            }
        }

        private void CheckAnswer()
        {
            if (exam.questions[currentQuestionIndex].IsCorrect(txtUserAnswer.Text))
            {
                mark++;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            currentQuestionIndex++;
            DisplayQuestion();
        }
    }
}
