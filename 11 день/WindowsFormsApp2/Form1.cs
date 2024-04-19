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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> dictionary = new Dictionary<string, double>();
        private Queue<double> queue = new Queue<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string key = keyTextBox.Text;
            double value;
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("en-US");

            if (double.TryParse(valueTextBox.Text, NumberStyles.Float, cultureInfo, out value))
            {
                dictionary[key] = value;
                queue.Enqueue(value);

                keyTextBox.Clear();
                valueTextBox.Clear();

                richTextBox1.AppendText($"{key}: {value.ToString()}" + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Некорректное значение для типа double!");
            }
        }

        private void fillQueueButton_Click(object sender, EventArgs e)
        {
            queue.Clear();
            foreach (double value in dictionary.Values)
            {
                queue.Enqueue(value);
            }

            richTextBox2.Clear();
            foreach (double value in queue)
            {
                richTextBox2.AppendText(value.ToString() + Environment.NewLine);
            }

            MessageBox.Show("Коллекция Queue<double> успешно заполнена!");
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int startIndex = (int)numericUpDown1.Value;
            int count = (int)numericUpDown2.Value;

            if (startIndex >= 0 && count > 0 && startIndex + count <= dictionary.Count)
            {
                var keysToRemove = new List<string>();

                // Определение ключей для удаления
                int currentIndex = 0;
                foreach (var key in dictionary.Keys)
                {
                    if (currentIndex >= startIndex && currentIndex < startIndex + count)
                    {
                        keysToRemove.Add(key);
                    }
                    currentIndex++;
                }

                // Удаление элементов по ключам
                foreach (var key in keysToRemove)
                {
                    dictionary.Remove(key);
                }

                richTextBox1.Clear();
                foreach (var item in dictionary)
                {
                    richTextBox1.AppendText($"{item.Key}: {item.Value.ToString()}" + Environment.NewLine);
                }

                richTextBox2.Clear();
                foreach (double value in queue)
                {
                    richTextBox2.AppendText(value.ToString() + Environment.NewLine);
                }

                MessageBox.Show($"Успешно удалено {count} элементов из коллекции!");
            }
            else
            {
                MessageBox.Show("Некорректные значения для удаления элементов!");
            }
        }
    }
}
