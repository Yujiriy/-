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

            
            int min = 100;
            int index = 0;
            int forChange;

            int[,] mas = new int[3, 4];
            Random rand = new Random();

            richTextBox1.Text = "";

            //заполнение случайными числами и замена по условию
            for (int i = 0; i < 3; i++)
            {
                min = 100;

                for (int j = 0; j < 4; j++)
                {
                    mas[i, j] = rand.Next(19, 99);
                    richTextBox1.Text += mas[i, j] + " ";

                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                        index = j;
                    }

                }

                richTextBox1.Text += "\n";
                forChange = mas[i, 0]; //первый элемент строки
                mas[i, 0] = min;
                mas[i, index] = forChange;  //обмен 
            }

            //Вывод уже обработанного массива
            richTextBox2.Text = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                   
                    richTextBox2.Text += mas[i, j] + " ";
                }
                richTextBox2.Text += "\n";


            }
        }
    }
}
