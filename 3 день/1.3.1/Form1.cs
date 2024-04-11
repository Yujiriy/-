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
            int[] mas = new int[N];
            mas[0] = 1;
            mas[1] = 1;

            richTextBox1.Text = "";
            richTextBox1.Text += mas[0] + " ";
            richTextBox1.Text += mas[1] + " ";

            for (int i = 2; i < N; i++)
            {
                mas[i] = mas[i - 2] + mas[i - 1];
                richTextBox1.Text += mas[i] + " ";
            }
        }
    }
}
