using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        SubjectDataAccess dataAccess = new SubjectDataAccess();
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

            List<string> statusNames = dataAccess.GetColumnValues("Statuses", "status_name");
            toolStripComboBox1.Items.AddRange(statusNames.ToArray());

        }


        private void PerformSearch(string searchText)
        {
  
            employeesBindingSource.Filter = "";
            employeesBindingSource.Filter = $"first_name LIKE '%{searchText}%' " +
                $"OR last_name LIKE '%{searchText}%'";
            employeesDataGridView.Refresh();
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = toolStripTextBox1.Text;
            
            PerformSearch(searchText);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            ToolStripComboBox toolStripComboBox = (ToolStripComboBox)sender;
            string selectedItem = toolStripComboBox.Text;

            int searchText = dataAccess.GetSubjectIndex(selectedItem);
            if (searchText != -1 )
            {
                employeesBindingSource.Filter = "";
                employeesBindingSource.Filter = $"status_id = '{searchText.ToString()}'";
                
            }
            else
            {
                employeesBindingSource.Filter = "";
            }

            employeesDataGridView.Refresh();
        }



    }
}
