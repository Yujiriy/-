using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ArrayProcessor arrayProcessor = new ArrayProcessor(100);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";



            arrayProcessor.LoadFromFile();
            
            foreach (int item in arrayProcessor.array)
                richTextBox1.AppendText($"{item} ");

            

            int sum = arrayProcessor.SumOfAbsoluteValuesAfterMax();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            arrayProcessor = new ArrayProcessor((int)numericUpDown1.Value);
            foreach (int item in arrayProcessor.array)
                richTextBox1.AppendText($"{item} ");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = arrayProcessor.SumOfAbsoluteValuesAfterMax().ToString();
        }
    }
}
