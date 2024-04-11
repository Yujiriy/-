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
            textBox1.Text = "12 15 20 30 60";
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string[] numbers = input.Split(' ');

            int[] values = new int[numbers.Length];
            CultureInfo culture = CultureInfo.InvariantCulture;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!int.TryParse(numbers[i], NumberStyles.Any, culture, out values[i]))
                {
                    richTextBox1.Text = "Ошибка ввода. Пожалуйста, введите корректные числовые значения.";
                    return;
                }
            }

            int lcm = LCM(values);

            richTextBox1.Text = $"НОК ({input}) равен: {lcm}";
        }

        static int LCM(params int[] numbers)
        {
            if (numbers.Length < 2)
                throw new ArgumentException("Для вычисления НОК требуется как минимум два числа.");

            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
                result = LCM(result, numbers[i]); //этого метода хватит и он будет работать даже для более 5 аргументов
                                                 //но задание с перегрузками поэтому оставлю и перегрузки по заданию

            return result;
        }

        static int LCM(int m, int n)
        {
            int answer = m;

            while (answer % n != 0)
            {
                answer += m;
            }
            return answer;
        }

        static int LCM(int m, int n, int k)
        {
            return LCM(LCM(m, n), k);
        }

        static int LCM(int m, int n, int k, int l)
        {
            return LCM(LCM(m, n, k), l);
        }

        static int LCM(int m, int n, int k, int l, int p)
        {
            return LCM(LCM(m, n, k, l), p);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
