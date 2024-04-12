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
        public Set set1;
        public Set set2;

        Set.Owner Owner1;
        Set.Owner Owner2;

        Set.Date Date1;
        Set.Date Date2;

        bool areEqual;
        bool areNotEqual;
        
        // Проверка оператора "%"
        public Set intersection;

        public Form1()
        {
            InitializeComponent();
            idBox.Text = "1";
            nameBox.Text = "NoName1";
            organizationBox.Text = "NoName1";

            idBox1.Text = "2";
            nameBox1.Text = "NoName2";
            organizationBox1.Text = "NoName2";

            


        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idBox.Text);
            string name = nameBox.Text;
            string org = organizationBox.Text;

            DateTime selectedDate = dateTimePicker1.Value;

            int day = selectedDate.Day;
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            Owner1 = new Set.Owner(id, name, org);
            Date1 = new Set.Date(day, month, year);

            set1 = new Set(Owner1, Date1);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            set1 += addBox.Text;
            richTextBox1.Text = set1.ToString();
            addBox.Text = "";
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            set1 -= addBox.Text;
            richTextBox1.Text = set1.ToString();
        }

        private void shortBtn_Click(object sender, EventArgs e)
        {
            shortBox.Text = set1.FindShortestWord();
        }

        private void setBtn1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idBox1.Text);
            string name = nameBox1.Text;
            string org = organizationBox1.Text;

            DateTime selectedDate = dateTimePicker2.Value;

            int day = selectedDate.Day;
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            Owner2 = new Set.Owner(id, name, org);
            Date2 = new Set.Date(day, month, year);

            set2 = new Set(Owner1, Date1);
        }

        private void addBtn1_Click(object sender, EventArgs e)
        {
            set2 += addBox1.Text;
            richTextBox2.Text = set2.ToString();
            addBox1.Text = "";
        }
        private void dltBtn1_Click(object sender, EventArgs e)
        {
            set2 -= addBox1.Text;
            richTextBox2.Text = set2.ToString();
        }

        private void shortBtn1_Click(object sender, EventArgs e)
        {
            shortBox1.Text = set2.FindShortestWord();
        }

        private void eqBtn_Click(object sender, EventArgs e)
        {
            areEqual = set1 == set2;
            richTextBox4.Text = areEqual.ToString();
        }

        private void neqBtn_Click(object sender, EventArgs e)
        {
            areNotEqual = set1 != set2;
            richTextBox4.Text = areNotEqual.ToString();
        }

        private void interBtn_Click(object sender, EventArgs e)
        {
            intersection = set1 % set2;
            string str ="";
            foreach (string item in intersection.Sort())
            {
                str += item + ", ";    
                
            }
            richTextBox4.Text = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setBtn.PerformClick();
            setBtn1.PerformClick();
        }
    }
}