using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {

        public LinkedList list = new LinkedList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text =  list.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            double num; 
            double.TryParse(textBox1.Text, NumberStyles.Any, culture, out num);
            list.Add(num);
            textBox1.Text = "";
            richTextBox1.Text = list.Print();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.RemoveAfterFirstPositive();
        }

        
    }

    public class Node
    {
        public double Value { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedList
    {
        private Node head;

        public void Add(double value)
        {   

            Node newNode = new Node { Value = value };

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void RemoveAfterFirstPositive()
        {
            Node current = head;
            while (current != null && current.Value <= 0)
            {
                current = current.Next;
            }

            if (current != null && current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        public string Print()
        {
            String str = "";
            Node current = head;
            while (current != null)
            {
                str += current.Value + " ";
                current = current.Next;
            }
            return str;
        }
    }
}
