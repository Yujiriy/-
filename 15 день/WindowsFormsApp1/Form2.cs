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
    public partial class Form2 : Form
    {
        public string EnteredText { get; private set; }

        public Form2(string title, string prompt)
        {
            InitializeComponent();
            Text = title;
            labelPrompt.Text = prompt;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            EnteredText = textBoxInput.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
