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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            double xStart = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            double xEnd = double.Parse(textBox2.Text, CultureInfo.InvariantCulture);
            double step = double.Parse(textBox3.Text, CultureInfo.InvariantCulture);
            double a = double.Parse(textBox4.Text, CultureInfo.InvariantCulture);
            double b = double.Parse(textBox5.Text, CultureInfo.InvariantCulture);
            double c = double.Parse(textBox6.Text, CultureInfo.InvariantCulture);

            dataGridView1.Rows.Clear();

            for (double x = xStart; x <= xEnd; x += step)
            {   
                double result;
                
                if (x - a < 0 && c != 0)
                    result = a - (x/(10+b));
                else if (x - a > 0 && c == 0)
                    result = (x - a) / (x - c);
                else
                    result = 3 * x + 2 / c;

                int intA = (int)a; // Целая часть числа a
                int intB = (int)b; // Целая часть числа b
                int intC = (int)c; // Целая часть числа c

                if (((intA | intB) & intC) == 0)
                {
                    result = (int)result;
                }

                dataGridView1.Rows.Add(x, result);
            }
        }
    }
}
