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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, z=0;
            CultureInfo culture = CultureInfo.InvariantCulture; // для обработки чисел с запятой и точкой и для в степени 2E10

            if (double.TryParse(textBox1.Text, NumberStyles.Any, culture, out x))
            {
                int pow = 1;
                double chlen;
                double previousChlen = 0;


                do
                {
                    chlen = Math.Pow((2 * x), pow) / Factorial(pow);
                    z += (double)chlen;
                    pow++;

                    if (Math.Abs(chlen - previousChlen) <= 0.001f)
                    {
                        break;
                    }

                    previousChlen = chlen;
                } while (true);


                richTextBox1.Text = $"{z}";
            }
            else
            {
                richTextBox1.Text = "Ошибка ввода. Пожалуйста, введите корректные числовые значения.";
            }
        }

        double  Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Factorial(n - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
