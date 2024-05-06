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
        private Form form3;
        private Form form4;
        private Form form5;
        private Form form6;
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            form3 = new Form3();
            form4 = new Form4();
            form5 = new Form5();
            form6 = new Form6();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            form3.TopLevel = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(form3);
            form3.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            form4.TopLevel = false;
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(form4);
            form4.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            form5.TopLevel = false;
            form5.FormBorderStyle = FormBorderStyle.None;
            form5.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(form5);
            form5.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            form6.TopLevel = false;
            form6.FormBorderStyle = FormBorderStyle.None;
            form6.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(form6);
            form6.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
