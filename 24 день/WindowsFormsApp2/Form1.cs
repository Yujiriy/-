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
       
        public DataGridView dataGridView2;
        public Form1()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadFormStudents();
            LoadForm2();
            LoadFormSpec();
            LoadFormGrades();

            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.studentsDataSet.Students);

        }

        private void LoadForm2()
        {
            Groups form2 = new Groups();

            form2.TopLevel = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(form2);
            form2.Show();

        }

        private void LoadFormStudents()
        {
            Students st = new Students();

            st.TopLevel = false;
            st.FormBorderStyle = FormBorderStyle.None;
            st.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(st);
            st.Show();

        }

        private void LoadFormSpec()
        {
            Speccs speccs = new Speccs();

            speccs.TopLevel = false;
            speccs.FormBorderStyle = FormBorderStyle.None;
            speccs.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(speccs);
            speccs.Show();

        }

        private void LoadFormGrades()
        {
            Grades grades = new Grades();
            //grades.FilterDataByField(2);


            grades.TopLevel = false;
            grades.FormBorderStyle = FormBorderStyle.None;
            grades.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(grades);
            grades.Show();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        
            // Получение выбранной строки в DataGridView
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                MessageBox.Show($"{selectedRow}");
                // Получение значения выбранной ячейки
                //string selectedValue = selectedRow.Cells["YourColumnName"].Value.ToString();

                // Установка фильтра на DataGridView
                //((DataTable)dataGridView2.DataSource).DefaultView.RowFilter = $"YourColumnName = '{selectedValue}'";
            }
        }
    }
}
