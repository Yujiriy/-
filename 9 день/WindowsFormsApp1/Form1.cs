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
        private Series<Function> series;

        public Form1()
        {
            InitializeComponent();
            Function ellipse = new Ellipse();
            Function parabola = new Parabola();
            Function hyperbola = new Hyperbola();
            Function[] functions = { ellipse, hyperbola, parabola };

            series = new Series<Function>(functions);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            CultureInfo cultureInfo = new CultureInfo("en-US");
            if (!double.TryParse(textBox1.Text, NumberStyles.Float, cultureInfo, out x))
            {
                errorProvider1.SetError(textBox1, "Некорректно введено");
            }
            else
            {
                errorProvider1.Clear();
                string results = series.CalculateAndDisplayResults(x);
                richTextBox1.Text = results;
            }
        }
    }
}