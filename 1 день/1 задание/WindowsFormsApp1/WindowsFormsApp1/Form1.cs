using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "-15.246";
            textBox2.Text = "4.642E-2";
            textBox3.Text = "20.001E2";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            CultureInfo culture = CultureInfo.InvariantCulture; // для обработки чисел с запятой и для в степени 2E10

            if (double.TryParse(textBox1.Text, NumberStyles.Any, culture, out x) &&
                double.TryParse(textBox2.Text, NumberStyles.Any, culture, out y) &&
                double.TryParse(textBox3.Text, NumberStyles.Any, culture, out z))
            {
               
                double a = Math.Log(Math.Pow(y, -Math.Sqrt(Math.Abs(x)))) * (x - y / 2) +
                 Math.Pow(Math.Sin(Math.Atan(z)), 2);

                richTextBox1.Text = $"Результат выражения равен: {a}";
            }
            else
            {
                richTextBox1.Text = "Ошибка ввода. Пожалуйста, введите корректные числовые значения.";
            }
        }
    }
}
