using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // Получение введенных значений из TextBox
            string[] p1Coordinates = textBox1.Text.Split(' ');
            string[] p2Coordinates = textBox2.Text.Split(' ');
            string[] p3Coordinates = textBox3.Text.Split(' ');
            string[] p4Coordinates = textBox4.Text.Split(' ');

            // Проверка правильности ввода
            if (p1Coordinates.Length != 2 || p2Coordinates.Length != 2 || p3Coordinates.Length != 2 || p4Coordinates.Length != 2)
            {
                MessageBox.Show("Некорректный ввод. Введите два числа через пробел для каждой точки.");
                return;
            }

            // Преобразование введенных значений в числа
            if (!float.TryParse(p1Coordinates[0], out float p1x) || !float.TryParse(p1Coordinates[1], out float p1y) ||
                !float.TryParse(p2Coordinates[0], out float p2x) || !float.TryParse(p2Coordinates[1], out float p2y) ||
                !float.TryParse(p3Coordinates[0], out float p3x) || !float.TryParse(p3Coordinates[1], out float p3y) ||
                !float.TryParse(p4Coordinates[0], out float p4x) || !float.TryParse(p4Coordinates[1], out float p4y))
            {
                MessageBox.Show("Некорректный ввод. Введите числа для координат точек.");
                return;
            }

            // Вычисление площади прямоугольника пересечения
            float intersectionArea = CalculateIntersectionArea(p1x, p1y, p2x, p2y, p3x, p3y, p4x, p4y);

            if (intersectionArea == 0.0f)
            {
                MessageBox.Show("Прямоугольники не пересекаются.");
            }
            else
            {
                MessageBox.Show("Прямоугольники пересекаются.\n" +
                    "Площадь прямоугольника пересечения: " + intersectionArea);
            }
        }

        private float CalculateIntersectionArea(float p1x, float p1y, float p2x, float p2y, float p3x, float p3y, float p4x, float p4y)
        {
            // Проверка пересечения прямоугольников
            if (p1x > p4x || p2x < p3x || p1y > p4y || p2y < p3y)
            {
                return 0.0f; // Прямоугольники не пересекаются
            }

            // Вычисление координат прямоугольника пересечения
            float intersectionLeft = Math.Max(p1x, p3x);
            float intersectionRight = Math.Min(p2x, p4x);
            float intersectionBottom = Math.Max(p1y, p3y);
            float intersectionTop = Math.Min(p2y, p4y);

            // Вычисление площади прямоугольника пересечения
            float intersectionArea = (intersectionRight - intersectionLeft) * (intersectionTop - intersectionBottom);

            return intersectionArea;
        }
    }
}
