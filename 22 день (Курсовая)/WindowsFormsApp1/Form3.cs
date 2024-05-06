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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            employeesDataGridView.Dock = DockStyle.Fill;
            
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employessDataSet);
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employessDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.employessDataSet.Employees);

            /*dataGridViewTextBoxColumn10.Items.Clear();
            dataGridViewTextBoxColumn10.Items.Add("Активен");
            dataGridViewTextBoxColumn10.Items.Add("Уволен");
            dataGridViewTextBoxColumn10.Items.Add("Отпуск");
            dataGridViewTextBoxColumn10.Items.Add("Болничный");*/

        }
    }
}
