using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string RemovePunctuation(string input)
        {
            return new string(input.Where(c => !char.IsPunctuation(c)).ToArray());
        }

        private string AddSymbols(string input)
        {
            return input + "###";
        }

        private string ReplaceToUpper(string input)
        {
            return input.ToUpper();
        }

        private string TrimSpaces(string input)
        {
            return input.Trim();
        }

        private string DuplicateEachChar(string input)
        {
            return string.Concat(input.SelectMany(c => new string(c, 2)));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Func<string, string> processString = RemovePunctuation;
            processString += AddSymbols;
            processString += ReplaceToUpper;
            processString += TrimSpaces;
            processString += DuplicateEachChar;

            string input = textBox1.Text;
            string result = input;

            foreach (Func<string, string> func in processString.GetInvocationList())
            {
                result = func(result);
            }

            textBox2.Text = result;
        }

        

    }
}
