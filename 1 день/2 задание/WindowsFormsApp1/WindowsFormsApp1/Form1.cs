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
            double a, b;
            CultureInfo culture = CultureInfo.InvariantCulture; // для обработки чисел с запятой и для в степени 2E10

            if (double.TryParse(textBox1.Text, NumberStyles.Any, culture, out a) &&
                double.TryParse(textBox2.Text, NumberStyles.Any, culture, out b) )
            {
               
                double z = Math.Sqrt( 
                    (Math.Sin(Math.PI + Math.Pow(b,2)))
                    / 
                    (Math.Pow(a, 2) * (Math.Sin(a) + Math.Pow(b, 2) * Math.Cos(7.2f)))
                    ) ;

                richTextBox1.Text = $"Корень частного синуса суммы числа Пи и числа B^2" +
                    $" на произведение A^2 и числа равному синусу суммы a и " +
                    $"произведения b^2 на косинус 7.2 равен: {z}";
            }
            else
            {
                richTextBox1.Text = "Ошибка ввода. Пожалуйста, введите корректные числовые значения.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
