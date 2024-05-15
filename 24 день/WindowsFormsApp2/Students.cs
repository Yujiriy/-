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
    public partial class Students : Form
    {
        public int StudentId;
        public Students()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.studentsDataSet.Students);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (studentsDataGridView.CurrentRow != null)
            {
                int StudentId =  int.Parse(studentsDataGridView.CurrentRow.Cells[2].Value.ToString());
                
            }


        }


    }
}
