using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Text);
            int K = int.Parse(textBox2.Text);
            int L = int.Parse(textBox3.Text);

            int sum = 0;

            int[] mas = new int[N];
            Random rand = new Random();

            richTextBox1.Text = "Текущий массив:";

            //заполнение случайными числами
            for (int i = 0; i < N; i++)
            {
                mas[i] = rand.Next(0,9);
            }

            //обработка по условию
            for (int i = 0; i < N; i++)
            {
                richTextBox1.Text += mas[i] + " ";
                if (i<K || i > L)
                {
                    sum += mas[i];
                } 
            }
            richTextBox1.Text += $"Сумма элементов массива без элементов в диапозоне {K} и {L}: Сумма {sum}";
        }
    }
}
