using System;
using System.IO;
using System.Windows.Forms;


/*
 * Программа тестирования загружает файл с тестом 
 * В программме присуствует перемешивание вариантов ответа
 * Есть таймер который дает на тест 60 секунд
 */
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private StreamReader reader;
        Random random = new Random();
        byte eval;
        byte timer;
        int ans_id;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFile("test.txt");
            ans_id = DisplayNextQuestion();
            eval = 0;
            timer = 0;
            timer1.Start();
        }
        private void OpenFile(string filePath)
        {
            try
            {
                reader = new StreamReader(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при открытии файла: " + ex.Message);
                Close();

            }
        }

        private int DisplayNextQuestion()
        {
            string q_o = reader.ReadLine();

            if (q_o != null)
            {
                richTextBox1.Text = q_o;
                string[] q_o_mas = MixArray(reader.ReadLine().Split(';'));

                int index = Array.FindIndex(q_o_mas, element => element.Contains("#"));
                // поиск индекса с правильным ответом, правильный ответ содержит в себе #
                q_o_mas[index] = q_o_mas[index].Replace("#", "");

                Console.WriteLine(q_o);
                Console.WriteLine(index);
                Console.WriteLine(q_o_mas[index]);

                radioButton1.Text = q_o_mas[0];
                radioButton2.Text = q_o_mas[1];
                radioButton3.Text = q_o_mas[2];
                radioButton4.Text = q_o_mas[3];

                reader.ReadLine();

                return index;

            }
            else
            {
                timer1.Stop();
                MessageBox.Show($"Вопросы закончились.\n Ваша оценка:{eval}");
                Close();
                return -1;
            }
        }

        // перемешать варианты ответа
        private string[] MixArray(string[] array)
        {

            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                string temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            return array;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            int remainingTime = 60 - timer; // Рассчитываем оставшееся время на тест
            label1.Text = $"Оставшееся время:{remainingTime.ToString()} секунд";
            if (remainingTime <= 0)
            {
                timer1.Stop(); // Останавливаем таймер, если время на тест истекло
                MessageBox.Show($"Время на тест истекло.\n Ваша оценка: {eval}");
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (GetRadio(ans_id).Checked == true)
            {
                eval++;
            }
             ans_id = DisplayNextQuestion();
        }

        private RadioButton GetRadio(int ans_id)
        {

            switch (ans_id)
            {
                case 0:
                    return radioButton1;
                case 1:
                    return radioButton2;
                case 2:
                    return radioButton3;
                case 3:
                    return radioButton4;
                default:
                    return radioButton1;
            }

        }


    }
}
