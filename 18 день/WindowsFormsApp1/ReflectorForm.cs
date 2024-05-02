using System;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class ReflectorForm : Form
    {
        private string selectedClass;

        public ReflectorForm()
        {
            InitializeComponent();
        }

        private void ReflectorForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("WindowsFormsApp1.Classes.Admin");
            comboBox1.Items.Add("WindowsFormsApp1.Classes.Student");
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedClass = comboBox1.SelectedItem.ToString();
            string classData = Reflector.PrintDataOfClass(selectedClass);
            richTextBox1.Clear();
            richTextBox1.AppendText(classData);
        }

        private void PrintDataOfClass_Click(object sender, EventArgs e)
        {
            string classData = Reflector.PrintDataOfClass(selectedClass);
            richTextBox1.Clear();
            richTextBox1.AppendText(classData);
        }

        private void GetMethods_Click(object sender, EventArgs e)
        {
            string methodsData = Reflector.GetMethods(selectedClass);
            richTextBox1.Clear();
            richTextBox1.AppendText(methodsData);
        }

        private void GetFieldsAndProperties_Click(object sender, EventArgs e)
        {
            string fieldsPropertiesData = Reflector.GetFieldsAndProperties(selectedClass);
            richTextBox1.Clear();
            richTextBox1.AppendText(fieldsPropertiesData);
        }

        private void GetInterfaces_Click(object sender, EventArgs e)
        {
            string interfacesData = Reflector.GetInterfaces(selectedClass);
            richTextBox1.Clear();
            richTextBox1.AppendText(interfacesData);
        }

        private void PrintMethodsByParameter_Click(object sender, EventArgs e)
        {
            string parameterTypeName = "System.String";
            string methodsData = Reflector.PrintMethodsByParameter(selectedClass, parameterTypeName);
            richTextBox1.Clear();
            richTextBox1.AppendText(methodsData);
        }

        private void CallMethodFromFile_Click(object sender, EventArgs e)
        {
            string methodName = "GetAnswer";
            string fileName = "parameter_values.txt";
            string methodResult = Reflector.CallMethodFromFile(selectedClass, methodName, fileName);
            richTextBox1.Clear();
            richTextBox1.AppendText(methodResult);
        }
    }
}