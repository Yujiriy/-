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
    public partial class Groups : Form
    {
        
        public Groups()
        {
            InitializeComponent();

        }
        public DataGridView GroupDataGridView
        {
            get { return groupsDataGridView; }
        }

        private void groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.studentsDataSet.Groups);

        }

        
    }
}
